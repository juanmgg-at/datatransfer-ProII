using ExcelDataReader.Log;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;



namespace DataExtractionNamespace
{

    class DataExtraction
    {
        static void Main()
        {


            // Open workspace
            AZClientTools.IAZWorkspace ws = Utilis.OpenWorkspace();

            // Instantiate class for accessing attribute values in the database 
            AZCMappingSvcs.Main Mapping = new AZCMappingSvcs.Main();

     
            // List to store CSV rows
            List<string> csvRows = new List<string>();

            List<TestCaseInfo> filteredTests = Utilis.GetFilteredTestCases();


            Console.WriteLine("Attribute Extraction");


            Dictionary<string, int> keyIdCounterPair = new Dictionary<string, int>();


            filteredTests.ForEach(testCase =>
            {

                Console.WriteLine($"    Extracting attibutes for Test case: {testCase.SheetName}, Equipment: {testCase.ClassName} ({testCase.Oid})");

                // Select classview
                string className = testCase.ClassName;  
                // Get Object OID
                string oid = testCase.Oid;
                // Get sheet name
                string sheetName = testCase.SheetName;

                // Extract attribute values
                AZCMappingSvcs.AZCViewAttributes attributes;
                string text;
                attributes = Mapping.ReadViewEx(ws, Environment.application, Environment.usage, className, int.Parse(oid), 0, out text);

                // Iterate over the extracted attributes
                foreach (AZCMappingSvcs.AZCViewAttribute attr in attributes)

                {
                    string attributeName = attr.Name;
                    string units = attr.Units;

                    bool isNumber = attr.Value is double || attr.Value is int;
                    bool isString = attr.Value is string && attr.Value != "";
                    bool isValid = isNumber || isString;

                    if (!isValid) continue;

                    string keyId = $"{sheetName}|{className}|{attributeName}";

                    // Check if the keyId already exists. This guarantees a unique keyId for each row in a sheet in extracted attributes file
                    if (!keyIdCounterPair.ContainsKey(keyId))
                    {
                        keyIdCounterPair.Add(keyId, 1);

                    }
                    else
                    {
                        keyIdCounterPair[keyId] += 1;
                        attributeName += keyIdCounterPair[keyId];

                    }

                    string csvRow = "";
                    // Add attribute to CSV rows
                    // when value is of type double and bigger than 0



                    //if ((className == "ColumnSection" || className == "Distillation" || className == "AirCooledExchanger") && isString)
                    //{

                    //    csvRow = $"{oid},{sheetName},{className},{attributeName},{attr.Value},{units}";
                    //    csvRows.Add(csvRow);

                    //}
                    //else if (isNumber)

                    //{

                    //    csvRow = $"{oid},{sheetName},{className},{attributeName},{attr.Value},{units}";


                    //    csvRows.Add(csvRow);

                    //}

                    csvRow = $"{oid},{sheetName},{className},{attributeName},{attr.Value},{units}";


                    csvRows.Add(csvRow);

                }



            });

            // Write CSV header
            string csvHeader = "Oid,SheetName,ClassName,Name,Value,Units";


            csvRows.Insert(0, csvHeader);

            // Write CSV file
            string extractedDataPath = $@"{Environment.pathToStoreFiles}extracted_data.csv";
            File.WriteAllLines(extractedDataPath, csvRows);

            Utilis.CompareFiles(Environment.baselinePathFile, extractedDataPath);

            Console.WriteLine("Done!");

            Console.ReadKey();
        }
    }
}


