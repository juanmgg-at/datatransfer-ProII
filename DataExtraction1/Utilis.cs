using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Data;
using ExcelDataReader;
using System.Text;


namespace DataExtractionNamespace
{

    public static class Utilis
    {

        public static List<TestCaseInfo> GetFilteredTestCases()
        {
            // List to hold the test case information
            List<TestCaseInfo> filteredTestCases = new List<TestCaseInfo>();

            // Loop through each title in TitleToTestId
            foreach (var title in Environment.TitleToTestId)
            {
                string titleName = title.Key; // Get the title name
                int testId = title.Value;

                // Check if CLS_OID contains this number and add the corresponding test cases
                if (TestCases.TestId_ObjIdClassName.TryGetValue(testId, out var OidClassNamePairs))
                {
                    foreach (var OidClassNamePair in OidClassNamePairs)
                    {
                        // Add to list with title, oid, and class name
                        filteredTestCases.Add(new TestCaseInfo(titleName, OidClassNamePair.Key, OidClassNamePair.Value));
                    }
                }
            }

            return filteredTestCases;
        }
        public static AZClientTools.IAZWorkspace OpenWorkspace()
        {
            // Create workspace
            AZClientTools.IAZWorkspace ws = new AZClientTools.AZWorkspace()
            {
                Workspace = Environment.WorkspaceName,
                BusinessServer = Environment.BusinessServer
            };

            // Connect to workspace
            ws.Connect();

            // Log status
            Console.WriteLine($"Status: {ws.Status}");

            return ws;
        }

        public static List<AttributeRecord> ReadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                return csv.GetRecords<AttributeRecord>().ToList();
            }
        }

        public static List<AttributeRecord> ReadExcel(string filePath, string sheetName)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true // Use the first row as the header
                        }
                    });

                    var dataTable = result.Tables[sheetName];
                    if (dataTable == null)
                    {
                        throw new ArgumentException($"Sheet '{sheetName}' not found in the Excel file.");
                    }

                    var records = new List<AttributeRecord>();
                    foreach (DataRow row in dataTable.Rows)
                    {

                        if (row.IsNull(0)) break;
                        // Assuming AttributeRecord has properties that match the columns
                        var record = new AttributeRecord
                        {
                            ClassName = row["ClassName"].ToString(),
                            Name = row["Name"].ToString(),
                            Value = row["Baseline"].ToString(),
                            Units = row["Units"].ToString()

                        };

                        records.Add(record);

                    }

                    return records;
                }
            }
        }

        public static void CompareFiles(string baselinePath, string extractedDataPath)
        {

            List<string> sheetNames = new List<string>(Environment.TitleToTestId.Keys);

            List<AttributeRecord> extractedDataValues = ReadCsv(extractedDataPath);

            Console.WriteLine("Comparison testing");

            Dictionary<string, int> TestNumFailsPair = new Dictionary<string, int>();
            // The comination className|attributeName must be unique in each sheet
            foreach (string sheetName in sheetNames) {

                Console.WriteLine($"    Comparing attributes in {sheetName}");

                
                // Get attributes for the current sheet in baseline
                List<AttributeRecord> filteredExtractedDataValues = extractedDataValues
                    .Where(r => r.SheetName.Trim().Equals(sheetName.Trim(), StringComparison.OrdinalIgnoreCase))
                    .ToList();

       
                List<AttributeRecord> baselineValues = ReadExcel(baselinePath, sheetName);

                // Check for missing combinations
                var missingCombinations = baselineValues
                    .Where(b => !filteredExtractedDataValues.Any(e =>
                        e.ClassName == b.ClassName &&
                        e.Name == b.Name &&
                        e.Units == b.Units))
                    .Select(b => new
                    {
                        
                        b.ClassName,
                        b.Name,
                        b.Units,
                        Baseline = b.Value,
                        FailReason = "Missing"
                    })
                    .ToList();

                int fails = 0; // Count fails for each test case

                var existingRows = new HashSet<string>();
                // Compare based on ClassName, Name, and Units
                var comparer = baselineValues.Join(
                    filteredExtractedDataValues,
                    r1 => new { r1.ClassName, r1.Name, r1.Units },
                    r2 => new { r2.ClassName, r2.Name, r2.Units },
                    (r1, r2) =>
                    {

                        bool IsSame = false;
                        IsSame = AreDecimalsEqual(r1.Value, r2.Value);


                        // Create a unique key based on ClassName, Name, and Units
                        // In same Test Case can find multiple equipments (different oid) with same key, so only consider the first equipment. In order for this to wrk the order to tests in TestCases.cs is important.
                        //var key = $"{r1.ClassName}|{r1.Name}|{r1.Units}";


                        //// Check if the key already exists
                        //if (!existingRows.Add(key)) // Add returns false if the key was already present
                        //{
                        //    return null; // Skip this entry
                        //}

                        if (!IsSame) fails++;


                        return new
                        {
                            r2.Oid,
                            r1.ClassName,
                            r1.Name,
                            Baseline = r1.Value,
                            r2.Value,
                            IsSame,
                            r1.Units,
                            Fail = IsSame ? null : "X",
                        };
                    }
                    );
                //).Where(x => x != null); // Filter out null entries;


                // List to store CSV rows
                List<string> csvRows = new List<string>();
                
                foreach (var item in comparer)
                {
                    string csvRow = "";
                    csvRow = $"{item.Oid},{item.ClassName},{item.Name},{item.Value},{item.Baseline},{item.Units},{(item.IsSame ? "✔" : "✖")}";
                    csvRows.Add(csvRow);

                }

                foreach (var item in missingCombinations)
                {
                    fails++;
                    string csvRow = "";
                    csvRow = $"N/A,{item.ClassName},{item.Name},N/A,{item.Baseline},{item.Units},✖,Missing";
                    csvRows.Add(csvRow);

                }

                // Write CSV header
                string csvHeader = "Oid,ClassName,Name,Value,Baseline,Units,IsSame";
                csvRows.Insert(0, csvHeader);

                // Append test summary
                string testSummary = $"Test Summary: {(fails > 0 ? "Fail" : "Pass")}, Number of Fails: {fails}";
                csvRows.Add(testSummary);

                // Write CSV file
                string csvFilePath = $@"{Environment.pathToStoreFiles}\\TestResults\\{sheetName}-attribute_test.csv";

                File.WriteAllLines(csvFilePath, csvRows, Encoding.UTF8);



                if (fails > 0)
                {

                    TestNumFailsPair.Add(sheetName, fails);
                }

            }
               
            CreateGeneralTestSummary(TestNumFailsPair, sheetNames);

        }

        public static decimal? ParseDecimal(string value)
        {
            try
            {
                return decimal.Parse(value, System.Globalization.NumberStyles.Float);
            }
            catch
            {
                return null; // Return null if parsing fails
            }
        }

        public static bool AreDecimalsEqual(string value1, string value2, int precision = 3)
        {
            var decimal1 = ParseDecimal(value1);
            var decimal2 = ParseDecimal(value2);

            if (decimal1.HasValue && decimal2.HasValue)
            {
                // Compare rounded values
                return Math.Round(decimal1.Value, precision) == Math.Round(decimal2.Value, precision);
            }

            // If parsing fails, fall back to string comparison
            return value1.Trim() == value2.Trim();
        }

        public static void CreateGeneralTestSummary(Dictionary<string,int> TestNumFailsPair, List<string> sheetNames) {
            // After the outer loop, create a summary text file for fails
            string summaryFilePath = $@"{Environment.pathToStoreFiles}\\TestResults\\TestSummary.txt";

            // Check if the file exists, and if so, delete it to avoid appending
            if (File.Exists(summaryFilePath))
            {
                File.Delete(summaryFilePath);
            }

            // Prepare a list to hold summary lines
            List<string> summaryLines = new List<string>();

            // Add headers or introductory text
            summaryLines.Add("Test Summary Report");
            summaryLines.Add($"Total Sheets Compared: {sheetNames.Count}");
            summaryLines.Add("--------------------------------------------------");

            // Iterate through the TestNumFailsPair to summarize fails
            foreach (var entry in TestNumFailsPair)
            {
                summaryLines.Add($"Sheet: {entry.Key}, Number of Fails: {entry.Value}");
            }

            // Write the summary lines to the text file
            File.WriteAllLines(summaryFilePath, summaryLines);

            // Optional: Log to console for quick reference
            //Console.WriteLine($"Summary of fails written to: {summaryFilePath}");

        }
    }


}