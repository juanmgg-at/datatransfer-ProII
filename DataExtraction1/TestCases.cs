
using AZCMappingSvcs;
using System.Collections.Generic;


namespace DataExtractionNamespace
{

    internal class TestCases
    {
        public static readonly Dictionary<int, Dictionary<string, string>> TestId_ObjIdClassName = new Dictionary<int, Dictionary<string, string>>()
    {
        // 1. Pump & Pump Curves
        { 1, new Dictionary<string, string>
            {
                //Pump (CQ00730637)  Pump Curves (CQ00746630) 
                { "11", "Pump" }

            }
        },

        // 2. Heater & Heat Exchanger Side
        { 2, new Dictionary<string, string>
            {
                //Heater (CQ00746232)
                { "57", "HeaterCooler" },
                //Heat Exchanger Side (CQ00748041) Use FluidProfile OID
                { "79", "HeatingCoolingCurve" }
            }
        },

        // 3. Separator
        { 3, new Dictionary<string, string>
            {
                //Separator (CQ00746647)
                { "147", "Separator" }
            }
        },

        // 4. Valves
        { 4, new Dictionary<string, string>
            {
                //Valves (CQ00746645)
                { "206", "Valve" }
            }
        },

        // 5. SimpleShell&TubeHeatExchanger
        { 5, new Dictionary<string, string>
            {
                // Simple Shell&Tube (CQ00730631)
                { "305", "HeatExchanger" },

                // Simple Shell&Tube (CQ00730631) Use with Detailed
                // The order matters, Detailed goes second, otherwise test will fail. It has to do with the order of attributes in baseline
                { "243", "HeatExchanger" },

            }
        },

        // 6. RigorousShell&TubeHeatExchanger
        { 6, new Dictionary<string, string>
            {
                // Rigorous Shell&Tube (CQ00746228)
                { "377", "HeatExchanger" }
            }
        },

        // 71. Heat Curves Hot Side
        { 71, new Dictionary<string, string>
            {
                // Heat Curves (CQ00747072) Hot Side
                { "466", "HeatingCoolingCurve" },
            }
        },

        // 72. Heat Curves Cold Side
        { 72, new Dictionary<string, string>
            {
                // Heat Curves (CQ00747072) Cold Side
                { "468", "HeatingCoolingCurve" }
            }
        },

        // 8. SimplePlateHeatExchanger
        { 8, new Dictionary<string, string>
            {
                // Simple Plate Heat Exchanger (CQ00749672)
                { "517", "HeatExchanger" },
                // Simple Plate Heat Exchanger (CQ00749672) Use with Detailed
                 // The order matters, Detailed goes second, otherwise test will fail. It has to do with the order of attributes in baseline
                { "582", "HeatExchanger" },

            }
        },

        // 9. RigorousPlateHeatExchanger
        { 9, new Dictionary<string, string>
            {
                // Rigorous Plate Heat Exchanger (CQ00748791)
                { "631", "HeatExchanger" }
            }
        },

        // 10. SimpleAirCooledExchanger
        { 10, new Dictionary<string, string>
            {
                // Simple AirCooledExchanger (CQ00749670)
                { "686", "AirCooledExchanger" },

            }
        },

         // 11. RigorousAirCooledExchanger
        { 11, new Dictionary<string, string>
            {
                // Rigorous AirCooledExchanger (CQ00745140)
                { "755", "AirCooledExchanger" }
            }
        },

        // 12. Compressor & Compressor Curves
        { 12, new Dictionary<string, string>
            {
                // Compressor (CQ00744509)
                { "805", "Compressor" },
                // Compressor Curves (CQ00749608)
                { "862", "CurveData" },
                { "863", "CurveData" },
                { "864", "CurveData" },
                { "865", "CurveData" },
                { "866", "CurveData" },
                { "867", "CurveData" }
            }
        },

        // 13. MCompressor
        { 13, new Dictionary<string, string>
            {
                // MCompressor (CQ00749678)
                { "891", "CompressorStage" },
                { "892", "CompressorStage" },
                { "893", "CompressorStage" }
            }
        },

        // 14. Expander
        { 14, new Dictionary<string, string>
            {
                // Expander (CQ00744509)
                { "916", "Compressor" }
            }
        },

        // 15. Streams
        { 15, new Dictionary<string, string>
            {


                //Keep this order, otherwise test will fail
                // Streams (CQ00741379) ICPEbegin-1.apwz
                { "953", "PipingSystem" },
                // Streams (CQ00741379) Aspen_Plus_Scaling_Model_BaCO3_CO2_H2O.bkp
                { "973", "PipingSystem" },
                // Streams (CQ00741379) 161639.bkp
                { "1059", "PipingSystem" }
            }
        },

        // 16. Vessels
        { 16, new Dictionary<string, string>
            {
                // Vessels (CQ00748800)
                //Inlet 1
                { "1075", "Port" },
                //Inlet 2
                { "1093", "Port" },

            }
        },

        // 17. Utility
        { 17, new Dictionary<string, string>
            {
                // Utility (CQ00751155) Pump-Eletricity.bkp
                { "1151", "Pump" },
                // Utility (CQ00751155) Separator-Stream.bkp
                { "1190", "Separator" },
                //// Utility (CQ00751155) Compressor-Utility.bkp
                { "1249", "Compressor" },
                //// Utility (CQ00751155) AirCooler-Cooler_Utility.bkp
                { "1281", "AirCooledExchanger" }, // It fails
                //// Utility (CQ00751155) HeaterCooler_Utility.bkp
                { "1331", "HeaterCooler" },
                //// Utility (CQ00751155) Column_Utility.bkp  1394
                { "1351", "Condenser" },
                { "1376", "Reboiler" },
                //// Utility (CQ00751155) Expander-Electricity.bkp
                { "1767", "Compressor" }
            }
        },

        // 18. Column
        { 18, new Dictionary<string, string>
            {
                // Columns (CQ00748801 & CQ00748804) AbeAdsDistillation, PumpAround,  AbeAdsDistillationStage
                { "1806", "Distillation" },

                // Columns (CQ00748801 & CQ00748804) ABEAdsColumnSection, ABEAdsColumnTrays, ABEAdsColumnPacking
                { "2244", "ColumnSection" },
                { "2337", "ColumnSection" },

                // Columns (CQ00748801 & CQ00748804) T-2.Condenser T-2.Reboiler
                { "1807", "Condenser" },
                { "1832", "Reboiler" }
            }

        },

        //HYSYS 

        // 19. Pump & Pump Curves
        { 19, new Dictionary<string, string>
            {
                // Pump (CQ00734580) 
                { "11", "Pump" }

            }
        },

        // 20. Rigorous FireHeater
        { 20, new Dictionary<string, string>
            {
                // Rigorous FireHeater (CQ00748793)
                { "52", "FiredHeater" }
            }
        },

        // 21. Multimapping-HXHotSide
        { 21, new Dictionary<string, string>
            {
                // Multimapping-HX (CQ00747904) Hot Side
                { "175", "HeatingCoolingCurve" },
            }
        },

        // Multimapping-HXColdSide
        { 22, new Dictionary<string, string>
            {
                // Multimapping-HX (CQ00747904) Cold Side
                { "154", "HeatingCoolingCurve" }
            }
        },

        // 23. Separator
        { 23, new Dictionary<string, string>
            {
                // Seperator (CQ00746648)
                { "247", "Separator" }
            }
        },

         // 24. Valves
        { 24, new Dictionary<string, string>
            {
                // Vavle (CQ00746646)
                { "342", "Valve" }
            }
        },

        // 25. SimpleShell&TubeHE
        { 25, new Dictionary<string, string>
            {
                // SimpleShell&TubeHE (CQ00748796)
                { "400", "HeatExchanger" },


            }
        },

        // 26. RigorousShell&TubeHE
        { 26, new Dictionary<string, string>
            {
                // RigorousShell&TubeHE (CQ00746225)
                { "383", "HeatExchanger" },


            }
        },

         // 27. RigorousAirCooledHexchanger
        { 27, new Dictionary<string, string>
            {
                // RigorousAirCooledHexchanger (CQ00745132)
                { "516", "AirCooledExchanger" },

            }
        },

        // 28. HeatCurvesHot
        { 28, new Dictionary<string, string>
            {
                // HeatCurves (CQ00747073) Hot Side
                { "596", "HeatingCoolingCurve" },
            }
        },

        // 29. HeatCurvesCold
        { 29, new Dictionary<string, string>
            {
                // HeatCurves (CQ00747073) Cold Side
                { "604", "HeatingCoolingCurve" }
            }
        },

        // 30. Compressor & Compressor Curves
        { 30, new Dictionary<string, string>
            {
                // Compressor (CQ00744505)
                { "2622", "Compressor" },
                // Compressor Curves (CQ00744505)
                { "2633", "CurveData" },
                { "2634", "CurveData" },
                { "2635", "CurveData" },
                { "2636", "CurveData" },
                { "2637", "CurveData" },
                { "2638", "CurveData" },

            }
        },

         // 31. Expander
        { 31, new Dictionary<string, string>
            {
                // Expander (CQ00748768)
                { "1124", "Expander" }
            }
        },

         // 32. Streams
        { 32, new Dictionary<string, string>
            {


                // Stream (CQ00730633) Uswe MaterialPort-Inlet OID
                { "1160", "PipingSystem" },

            }
        },

        // 33. Vessels
        { 33, new Dictionary<string, string>

            {
                // Vessels
                //Inlet 1
                { "1209", "Port" },

            }
        },

         // 34. Utility
        { 34, new Dictionary<string, string>
            {
                // Pump-Utility
                { "1226", "Pump" },
                // Seperator-Utility
                { "1266", "PipingSystem" },
                //// Compressor Curve-Utility
                { "1271", "PipingSystem" },
                //// Deep Cut Turbo-Expander-Utility
                { "1276", "PipingSystem" },
                //// Acid Gas Cleaning Using MDEA-Utility
                { "1288", "PipingSystem" },
                //// Heater_Cooler-Utility
                { "1293", "PipingSystem" },
                //Heater_Cooler-Utility
                { "1295", "PipingSystem" },
            }
        },

        // 35. MCompressor
        { 35, new Dictionary<string, string>
            {
                // Multi-Compressors(CQ00730640)
                { "1084", "Compressor" },
                //{ "1481", "CompressorStage" },
                //{ "1482", "CompressorStage" }
            }
        },

        // 36. ColumnMainTS
        { 36, new Dictionary<string, string>
            {

            // Tray Section, Trays, Column Section 
            { "1304", "TraySection" },
            { "2279", "ColumnSection" },
        }

        },

        // 37. HeaterCooler
        { 37, new Dictionary<string, string>
            {

            { "112", "HeaterCooler" },
            { "129", "HeaterCooler" },

            }
        },

        // 38. ColumnTS1
        { 38, new Dictionary<string, string>
            {


            //TS-1 
            { "1748", "ColumnSection" },

            }
        },

        // 39. Simple HX
        { 39, new Dictionary<string, string>
             {
                 {"316", "HeatExchanger" }
             }

         },

        // 40. Pump
        { 40, new Dictionary<string, string>
             {
                 {"345", "Pump" }
             }

         },

        // 41. Valve
        { 41, new Dictionary<string, string>
             {
                 {"299", "Valve" }
             }

         },

        // 42. Flash
        { 42, new Dictionary<string, string>
             {
                 {"309", "Separator" }
             }

         },


            // 43. AirCooled
            {43, new Dictionary<string, string>
            {
                // Condenser_MultipleService1_AirCooled.EDR
                {"613", "AirCooledExchanger" },
                // Hydrocarbon-DryAir_DesFixAir_AirCooled
                {"662", "AirCooledExchanger" },
                // OilCooler_MultipleService2_AirCooled
                {"710", "AirCooledExchanger" }
            }
            },

            {44, new Dictionary<string, string>
            {

                // Condenser_DesignGivenPlate_PlateFrame.EDR
                {"754", "HeatExchanger" },
                //Steam-Water_Simulation_PlateFrame
                {"789", "HeatExchanger" },
                //Water_Water_Design_PlateFrame
                {"819", "HeatExchanger" },
            }

            },


            {45, new Dictionary<string, string>
            {
                //ForcedVaporizer_BEM.EDR
                {"849", "HeatExchanger" },
                //Ts-KnockbackConsenser-Vetical_AEL
                {"922", "HeatExchanger" },
                //TS-Thermosiphon-Vertical_BEM
                {"997", "HeatExchanger" },
            }

            }



    };

    }

}

