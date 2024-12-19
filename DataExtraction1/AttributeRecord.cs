using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractionNamespace
{
    public class AttributeRecord
    {

        public int? Oid {  get; set; }
        public string ClassName { get; set; }
        public string SheetName { get; set; }

        public string Name { get; set; }
        public string Value { get; set; }
        public string Units { get; set; }
    }
}
