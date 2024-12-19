using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractionNamespace
{
    public class TestCaseInfo
    {
        public string SheetName { get; set; }
        public string Oid { get; set; }
        public string ClassName { get; set; }



        public TestCaseInfo(string title, string oid, string className)
        {
            SheetName = title;
            Oid = oid;
            ClassName = className;

        }
    }
}
