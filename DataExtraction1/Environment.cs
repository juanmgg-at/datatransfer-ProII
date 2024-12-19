using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractionNamespace
{

    public static class Environment
    {
        public const string WorkspaceName = "DT1";
        public const string BusinessServer = "GUTIERRJ-S22.qae.aspentech.com";

        
        public const string application = "Mapper";
        public const string usage = "Equipment";

        public const string app = "HYSYS";

        // Modify this path to our repository path

        public const string pathToStoreFiles = "C:\\Users\\gutierrj\\Downloads\\data_transfer\\data_transfer\\DataExtraction1\\";

        public const string baselinePathFile = pathToStoreFiles + "baseline.xlsx";

        // The order here has to be the same as the order in TestCases
        public static readonly Dictionary<string, int> TitleToTestId = new Dictionary<string, int>
        {
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
            { "Utility", 17 },
            { "Column", 18 }

            //HYSYS only
            //{ "Pump & Pump Curves", 19 },
            //{"Rigorous FireHeater", 20 },
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
            //{ "HeaterCooler", 37 },
            //{ "ColumnTS1", 38 },


        };

    }
}
