using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractionNamespace
{

    public static class Environment
    {
        public const string WorkspaceName = "A3";
        public const string BusinessServer = "ABE-Automation.qae.aspentech.com";

        
        public const string application = "Mapper";
        public const string usage = "Equipment";

        public const string app = "HYSYS";

        // Modify this path to our repository path

        public const string pathToStoreFiles = @"C:\Users\gutierrj\source\repos\datatransfer-ProII\DataExtraction1\";


        //public const string baselinePathFile = pathToStoreFiles + "baseline.xlsx";
        //public const string baselinePathFile = pathToStoreFiles + "baseline-thermal-design.xlsx";
        //public const string baselinePathFile = pathToStoreFiles + "baseline-hysys.xlsx";
        public const string baselinePathFile = pathToStoreFiles + "baseline-ProII.xlsx";

        // The order here has to be the same as the order in TestCases
        public static readonly Dictionary<string, int> TitleToTestId = new Dictionary<string, int>
        {
            // A+ only
            // DO NOT DELETE THIS AND KEEP THE SAME ORDER
            // Uncomment what you want to test
            //{ "Pump & Pump Curves", 1 },
            //{ "Heater & Heat Exchanger Side", 2 },
            //{ "Separator", 3 },
            //{ "Valves", 4 },
            //{ "SimpleShell&TubeHeatExchanger", 5 },
            //{ "RigorousShell&TubeHeatExchanger", 6 },
            //{ "Heat Curves Hot Side", 71 },
            //{ "Heat Curves Cold Side", 72 },
            //{ "SimplePlateHeatExchanger", 8 },
            //{ "RigorousPlateHeatExchanger", 9 },
            //{ "SimpleAirCooledExchanger", 10 },
            //{ "RigorousAirCooledExchanger", 11 }, // Pending until defect is fixed
            //{ "Compressor & Compressor Curves", 12 },
            //{ "MCompressor", 13 }, // simulation runs with errors, it doesn't affect the transfer though
            //{ "Expander", 14 },
            //{ "Streams", 15 },
            //{ "Vessels", 16 },
            //{ "Utility", 17 },
            //{ "Column", 18 }

            //HYSYS only
            //{ "Pump & Pump Curves", 19 },
            //{"FireHeater", 20 },
            //{"Multimapping-HXHotSide", 21},
            //{"Multimapping-HXColdSide", 22},
            //{ "Separator", 23 },
            //{ "Valves", 24 },
            //{ "SimpleShell&TubeHE", 25 },
            //{ "RigorousShell&TubeHE", 26 },
            //{ "RigorousAirCooledHexchanger", 27 },
            //{ "HeatCurvesHot", 28 },
            //{ "HeatCurvesCold", 29 },
            //{ "Compressor & Compressor Curves", 30},
            //{ "Expander", 31 },
            //{ "Streams", 32 },
            //{ "Vessels", 33},
            //{ "Utility", 34 },
            //{"MCompressor",  35},
            //{ "ColumnMainTS", 36 },
            //{ "ColumnTS1", 37 },
            //{ "HeaterCooler", 38 },

            // ProII only 
            //{"Simple HX",  39},
            //{ "Pump", 40 },
            //{ "Valve", 41 },
            //{ "Flash", 42 },
            //{"Compressor", 43 },
            //{"Air Cooled HX", 44},
            //{"Stream", 45},
            //{"Bulk Phase & Liquid Phase", 46},
            //{"Vapor Phase", 47},
            //{"Distillation Columns and Trays", 48},
            //{"Mixer", 49},
            //{"Splitter", 50},
            //{"PumpAround", 51},
            //{"Tubine", 52},
            //{"SideColumn", 53},
            //{"DistillationPortData", 54},
            {"ValvePortData", 55},
            

            // Thermal Design Only 


            //{"AirCooled", 51 },
            //{"Plate", 52 },
            //{"Shell&Tube", 53 },

        };

    }
}
