
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
                { "2654", "Valve" }
            }
        },

        // 5. SimpleShell&TubeHeatExchanger
        { 5, new Dictionary<string, string>
            {
                // Simple Shell&Tube (CQ00730631)
                { "354", "HeatExchanger" },

                // Simple Shell&Tube (CQ00730631) Use with Detailed
                // The order matters, Detailed goes second, otherwise test will fail. It has to do with the order of attributes in baseline
                { "490", "HeatExchanger" },

            }
        },

        // 6. RigorousShell&TubeHeatExchanger
        { 6, new Dictionary<string, string>
            {
                // Rigorous Shell&Tube (CQ00746228)
                { "424", "HeatExchanger" }
            }
        },

        // 71. Heat Curves Hot Side
        { 71, new Dictionary<string, string>
            {
                // Heat Curves (CQ00747072) Hot Side
                { "2704", "HeatingCoolingCurve" },
            }
        },

        // 72. Heat Curves Cold Side
        { 72, new Dictionary<string, string>
            {
                // Heat Curves (CQ00747072) Cold Side
                { "2706", "HeatingCoolingCurve" }
            }
        },

        // 8. SimplePlateHeatExchanger
        { 8, new Dictionary<string, string>
            {
                // Simple Plate Heat Exchanger (CQ00749672)
                { "781", "HeatExchanger" },
                // Simple Plate Heat Exchanger (CQ00749672) Use with Detailed
                 // The order matters, Detailed goes second, otherwise test will fail. It has to do with the order of attributes in baseline
                { "844", "HeatExchanger" },

            }
        },

        // 9. RigorousPlateHeatExchanger
        { 9, new Dictionary<string, string>
            {
                // Rigorous Plate Heat Exchanger (CQ00748791)
                { "726", "HeatExchanger" }
            }
        },

        // 10. SimpleAirCooledExchanger
        { 10, new Dictionary<string, string>
            {
                // Simple AirCooledExchanger (CQ00749670)
                { "893", "AirCooledExchanger" },

            }
        },

         // 11. RigorousAirCooledExchanger
        { 11, new Dictionary<string, string>
            {
                // Rigorous AirCooledExchanger (CQ00745140)
                { "962", "AirCooledExchanger" }
            }
        },

        // 12. Compressor & Compressor Curves
        { 12, new Dictionary<string, string>
            {
                // Compressor (CQ00744509)
                { "1012", "Compressor" },
                // Compressor Curves (CQ00749608)
                { "1069", "CurveData" },
                { "1070", "CurveData" },
                { "1071", "CurveData" },
                { "1072", "CurveData" },
                { "1073", "CurveData" },
                { "1074", "CurveData" }
            }
        },

        // 13. MCompressor
        { 13, new Dictionary<string, string>
            {
                // MCompressor (CQ00749678) Use Stage object OIDs
                { "1098", "CompressorStage" },
                { "1099", "CompressorStage" },
                { "1100", "CompressorStage" }
            }
        },

        // 14. Expander
        { 14, new Dictionary<string, string>
            {
                // Expander (CQ00744509)
                { "1123", "Compressor" }
            }
        },

        // 15. Streams
        { 15, new Dictionary<string, string>
            {


                //Keep this order, otherwise test will fail
                // Streams (CQ00741379) ICPEbegin-1.apwz
                { "2753", "PipingSystem" },
                // Streams (CQ00741379) Aspen_Plus_Scaling_Model_BaCO3_CO2_H2O.bkp
                { "2773", "PipingSystem" },
                // Streams (CQ00741379) 161639.bkp
                { "2791", "PipingSystem" }
            }
        },

        // 16. Vessels
        { 16, new Dictionary<string, string>
            {
                // Vessels (CQ00748800)

            
                //Inlet 1
                { "1325", "Port" },
                //Inlet 2
                { "1343", "Port" },

            }
        },

        // 17. Utility
        { 17, new Dictionary<string, string>
            {
                // Utility (CQ00751155) Pump-Eletricity.bkp
                { "1936", "Pump" },
                // Utility (CQ00751155) Separator-Stream.bkp
                { "1975", "Separator" },
                //// Utility (CQ00751155) Compressor-Utility.bkp
                { "2034", "Compressor" },
                //// Utility (CQ00751155) AirCooler-Cooler_Utility.bkp
                { "1854", "AirCooledExchanger" }, // It fails in ElectricityUsage
                //// Utility (CQ00751155) HeaterCooler_Utility.bkp
                { "1835", "HeaterCooler" },
                //// Utility (CQ00751155) Column_Utility.bkp  1394
                { "1380", "Condenser" },
                { "1405", "Reboiler" },
                //// Utility (CQ00751155) Expander-Electricity.bkp
                { "1796", "Compressor" }
            }
        },

        // 18. Column
        { 18, new Dictionary<string, string>
            {
                // Columns (CQ00748801 & CQ00748804) AbeAdsDistillation, PumpAround,  AbeAdsDistillationStage
                { "4436", "Distillation" },

                // Columns (CQ00748801 & CQ00748804) ABEAdsColumnSection, ABEAdsColumnTrays, ABEAdsColumnPacking
                { "4874", "ColumnSection" },
                { "4967", "ColumnSection" },

                // Columns (CQ00748801 & CQ00748804) T-2.Condenser T-2.Reboiler
                { "4437", "Condenser" },
                { "4462", "Reboiler" }
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
                // Multimapping-HX (CQ00747904) Hot Side -> FluidProfile 
                { "136", "HeatingCoolingCurve" },
            }
        },

        // Multimapping-HXColdSide
        { 22, new Dictionary<string, string>
            {
                // Multimapping-HX (CQ00747904) Cold Side -> FluidProfile 
                { "114", "HeatingCoolingCurve" }
            }
        },

        // 23. Separator
        { 23, new Dictionary<string, string>
            {
                // Seperator (CQ00746648)
                { "209", "Separator" }
            }
        },

         // 24. Valves
        { 24, new Dictionary<string, string>
            {
                // Vavle (CQ00746646)
                { "307", "Valve" }
            }
        },

        // 25. SimpleShell&TubeHE
        { 25, new Dictionary<string, string>
            {
                // SimpleShell&TubeHE (CQ00748796)
                { "348", "HeatExchanger" },


            }
        },

        // 26. RigorousShell&TubeHE
        { 26, new Dictionary<string, string>
            {
                // RigorousShell&TubeHE (CQ00746225)
                { "418", "HeatExchanger" },

            }
        },

         // 27. RigorousAirCooledHexchanger
        { 27, new Dictionary<string, string>
            {
                // RigorousAirCooledHexchanger (CQ00745132)
                { "489", "AirCooledExchanger" },

            }
        },

        // 28. HeatCurvesHot
        { 28, new Dictionary<string, string>
            {
                // HeatCurves (CQ00747073) Hot Side -> FluidProfile 
                { "571", "HeatingCoolingCurve" },
            }
        },

        // 29. HeatCurvesCold
        { 29, new Dictionary<string, string>
            {
                // HeatCurves (CQ00747073) Cold Side -> FluidProfile 
                { "579", "HeatingCoolingCurve" }
            }
        },

        // 30. Compressor & Compressor Curves
        { 30, new Dictionary<string, string>
            {
                // Compressor (CQ00744505)
                { "620", "Compressor" },
                // Compressor Curves (CQ00744505)
                { "631", "CurveData" },
                { "632", "CurveData" },
                { "633", "CurveData" },
                { "634", "CurveData" },
                { "635", "CurveData" },
                { "636", "CurveData" },

            }
        },

         // 31. Expander
        { 31, new Dictionary<string, string>
            {
                // Expander (CQ00748768)
                { "653", "Expander" }
            }
        },

         // 32. Streams
        { 32, new Dictionary<string, string>
            {


                // Stream (CQ00730633) Uswe MaterialPort-Inlet OID
                { "690", "PipingSystem" },

            }
        },

        // 33. Vessels
        { 33, new Dictionary<string, string>

            {
                // Vessels
                //Inlet 1
                { "710", "Port" },

            }
        },

         // 34. Utility
        { 34, new Dictionary<string, string>
            {
                // Pump-Utility
                { "758", "Pump" },
                // Seperator-Utility
                { "800", "PipingSystem" },
                //// Compressor Curve-Utility
                { "805", "PipingSystem" },
                //// Deep Cut Turbo-Expander-Utility
                { "810", "PipingSystem" },
                //// Acid Gas Cleaning Using MDEA-Utility
                { "817", "PipingSystem" },
                //// Heater_Cooler-Utility
                { "822", "PipingSystem" },
                //Heater_Cooler-Utility
                { "827", "PipingSystem" },
            }
        },

        // 35. MCompressor
        { 35, new Dictionary<string, string>
            {
                // Multi-Compressors(CQ00730640)
                { "2262", "Compressor" },
                //{ "1481", "CompressorStage" },
                //{ "1482", "CompressorStage" }
            }
        },

        // 36. ColumnMainTS, use AbeAdsDistillation classview 
        { 36, new Dictionary<string, string>
            {

            // Tray Section, Trays, Column Section 
            { "833", "TraySection" }, // Use main object OID
            { "1852", "ColumnSection" }, // In ColumnSections
        }

        },

          // 37. ColumnTS1, use AbeAdsDistillation classview 
        { 37, new Dictionary<string, string>
            {
            //TS-1 
            { "1297", "ColumnSection" }, // In ColumnSections

            }
        },


        // 38. HeaterCooler
        { 38, new Dictionary<string, string>
            {

            { "112", "HeaterCooler" },
            { "129", "HeaterCooler" },

            }
        },

      



        // ProII 

        // 39. Simple HX
        { 39, new Dictionary<string, string>
             {
                 {"92", "HeatExchanger" }
             }

         },

        // 40. Pump
        { 40, new Dictionary<string, string>
             {
                 {"179", "Pump" }
             }

         },

        // 41. Valve
        { 41, new Dictionary<string, string>
             {
                 {"280", "Valve" }
             }

         },

        // 42. Flash
        { 42, new Dictionary<string, string>
             {
                 {"217", "Separator" }
             }

         },

         // 43. Compressor
        { 43, new Dictionary<string, string>
             {
                 {"322", "Compressor" }
             }

         },

         // 44. Air Cooled HX
        { 44, new Dictionary<string, string>
             {
                 {"366", "AirCooledExchanger" }
             }

         }, 
        
        // 45. Stream
        { 45, new Dictionary<string, string>
             {
                 {"471", "PipingSystem" }
             }

         },
        // 46. Bulk Phase & Liquid Phase
        { 46, new Dictionary<string, string>
             {
                 {"489", "PipingSystem" }
             }

         },
          // 47. Vapor Phase
        { 47, new Dictionary<string, string>
             {
                 {"507", "PipingSystem" }
             }

         },   
        
        // 48 Distillation Column and Trays
        { 48, new Dictionary<string, string>
             {
                 {"520", "Distillation" }
             }

         },

        // 49 Mixer
        { 49, new Dictionary<string, string>
             {
                 {"530", "Generic" }
             }

         },

        // 50 Splitter
        { 50, new Dictionary<string, string>
             {
                 {"695", "Generic" }
             }

         },



            //// 51. AirCooled
            //{51, new Dictionary<string, string>
            //{
            //    // Condenser_MultipleService1_AirCooled.EDR
            //    {"11", "AirCooledExchanger" },
            //    // Hydrocarbon-DryAir_DesFixAir_AirCooled
            //    {"", "AirCooledExchanger" },
            //    //// OilCooler_MultipleService2_AirCooled
            //    {"", "AirCooledExchanger" }
            //}
            //},

            //{52, new Dictionary<string, string>
            //{

            //    // Condenser_DesignGivenPlate_PlateFrame.EDR
            //    {"1", "HeatExchanger" },
            //    //Steam-Water_Simulation_PlateFrame
            //    {"2", "HeatExchanger" },
            //    //Water_Water_Design_PlateFrame
            //    {"3", "HeatExchanger" },
            //}

            //},


            //{53, new Dictionary<string, string>
            //{
            //    //ForcedVaporizer_BEM.EDR
            //    {"4", "HeatExchanger" },
            //    //Ts-KnockbackConsenser-Vetical_AEL
            //    {"5", "HeatExchanger" },
            //    //TS-Thermosiphon-Vertical_BEM
            //    {"6", "HeatExchanger" },
            //}

            //}



    };

    }

}

