
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
                { "629", "Pump" }

            }
        },

        // 2. Heater & Heat Exchanger Side
        { 2, new Dictionary<string, string>
            {
                //Heater (CQ00746232)
                { "674", "HeaterCooler" },
                //Heat Exchanger Side (CQ00748041) Use FluidProfile OID
                { "696", "HeatingCoolingCurve" }
            }
        },

        // 3. Separator
        { 3, new Dictionary<string, string>
            {
                //Separator (CQ00746647)
                { "770", "Separator" }
            }
        },

        // 4. Valves
        { 4, new Dictionary<string, string>
            {
                //Valves (CQ00746645)
                { "861", "Valve" }
            }
        },

        // 5. SimpleShell&TubeHeatExchanger
        { 5, new Dictionary<string, string>
            {
                // Simple Shell&Tube (CQ00730631)
                { "858", "HeatExchanger" },

                // Simple Shell&Tube (CQ00730631) Use with Detailed
                // The order matters, Detailed goes second, otherwise test will fail. It has to do with the order of attributes in baseline
                { "928", "HeatExchanger" },

            }
        },

        // 6. RigorousShell&TubeHeatExchanger
        { 6, new Dictionary<string, string>
            {
                // Rigorous Shell&Tube (CQ00746228)
                { "990", "HeatExchanger" }
            }
        },

        // 71. Heat Curves Hot Side
        { 71, new Dictionary<string, string>
            {
                // Heat Curves (CQ00747072) Hot Side
                { "806", "HeatingCoolingCurve" },
            }
        },

        // 72. Heat Curves Cold Side
        { 72, new Dictionary<string, string>
            {
                // Heat Curves (CQ00747072) Cold Side
                { "1079", "HeatingCoolingCurve" }
            }
        },

        // 8. SimplePlateHeatExchanger
        { 8, new Dictionary<string, string>
            {
                // Simple Plate Heat Exchanger (CQ00749672)
                { "1126", "HeatExchanger" },
                // Simple Plate Heat Exchanger (CQ00749672) Use with Detailed
                 // The order matters, Detailed goes second, otherwise test will fail. It has to do with the order of attributes in baseline
                { "1189", "HeatExchanger" },

            }
        },

        // 9. RigorousPlateHeatExchanger
        { 9, new Dictionary<string, string>
            {
                // Rigorous Plate Heat Exchanger (CQ00748791)
                { "1238", "HeatExchanger" }
            }
        },

        // 10. SimpleAirCooledExchanger
        { 10, new Dictionary<string, string>
            {
                // Simple AirCooledExchanger (CQ00749670)
                { "1293", "AirCooledExchanger" },

            }
        },

         // 11. RigorousAirCooledExchanger
        { 11, new Dictionary<string, string>
            {
                // Rigorous AirCooledExchanger (CQ00745140)
                { "1362", "AirCooledExchanger" }
            }
        },

        // 12. Compressor & Compressor Curves
        { 12, new Dictionary<string, string>
            {
                // Compressor (CQ00744509)
                { "1412", "Compressor" },
                // Compressor Curves (CQ00749608)
                { "1469", "CurveData" },
                { "1470", "CurveData" },
                { "1471", "CurveData" },
                { "1472", "CurveData" },
                { "1473", "CurveData" },
                { "1474", "CurveData" }
            }
        },

        // 13. MCompressor
        { 13, new Dictionary<string, string>
            {
                // MCompressor (CQ00749678) Use Stage object OIDs
                { "1498", "CompressorStage" },
                { "1499", "CompressorStage" },
                { "1500", "CompressorStage" }
            }
        },

        // 14. Expander
        { 14, new Dictionary<string, string>
            {
                // Expander (CQ00744509)
                { "1523", "Compressor" }
            }
        },

        // 15. Streams
        { 15, new Dictionary<string, string>
            {


                //Keep this order, otherwise test will fail
                // Streams (CQ00741379) ICPEbegin-1.apwz
                { "1636", "PipingSystem" },
                // Streams (CQ00741379) Aspen_Plus_Scaling_Model_BaCO3_CO2_H2O.bkp
                { "1656", "PipingSystem" },
                // Streams (CQ00741379) 161639.bkp
                { "1674", "PipingSystem" }
            }
        },

        // 16. Vessels
        { 16, new Dictionary<string, string>
            {
                // Vessels (CQ00748800)

                //Inlet 1
                { "3044", "Port" },
                //Inlet 2
                { "3062", "Port" },

            }
        },

        // 17. Utility
        { 17, new Dictionary<string, string>
            {
                // Utility (CQ00751155) Pump-Eletricity.bkp
                { "1745", "Pump" },
                // Utility (CQ00751155) Separator-Stream.bkp
                { "1781", "Separator" },
                //// Utility (CQ00751155) Compressor-Utility.bkp
                { "1840", "Compressor" },
                //// Utility (CQ00751155) AirCooler-Cooler_Utility.bkp
                { "1872", "AirCooledExchanger" }, // It fails in ElectricityUsage
                //// Utility (CQ00751155) HeaterCooler_Utility.bkp
                { "1922", "HeaterCooler" },
                //// Utility (CQ00751155) Column_Utility.bkp  1394
                { "1942", "Condenser" },
                { "1967", "Reboiler" },
                //// Utility (CQ00751155) Expander-Electricity.bkp
                { "2390", "Compressor" }
            }
        },

        // 18. Column
        { 18, new Dictionary<string, string>
            {
                // Columns (CQ00748801 & CQ00748804) AbeAdsDistillation, PumpAround,  AbeAdsDistillationStage
                { "2429", "Distillation" },

                // Columns (CQ00748801 & CQ00748804) ABEAdsColumnSection, ABEAdsColumnTrays, ABEAdsColumnPacking
                { "2867", "ColumnSection" },
                { "2960", "ColumnSection" },

                // Columns (CQ00748801 & CQ00748804) T-2.Condenser T-2.Reboiler
                { "2430", "Condenser" },
                { "2455", "Reboiler" }
            }

        },

        //HYSYS 

        // 19. Pump & Pump Curves
        { 19, new Dictionary<string, string>
            {
                // Pump (CQ00734580) 
                { "49", "Pump" }

            }
        },

        // 20. FireHeater
        { 20, new Dictionary<string, string>
            {
                // FireHeater (CQ00748793)
                { "89", "FiredHeater" }
            }
        },

        // 21. Multimapping-HXHotSide
        { 21, new Dictionary<string, string>
            {
                // Multimapping-HX (CQ00747904) Hot Side -> FluidProfile 
                { "2581", "HeatingCoolingCurve" },
            }
        },

        // Multimapping-HXColdSide
        { 22, new Dictionary<string, string>
            {
                // Multimapping-HX (CQ00747904) Cold Side -> FluidProfile 
                { "2559", "HeatingCoolingCurve" }
            }
        },

        // 23. Separator
        { 23, new Dictionary<string, string>
            {
                // Seperator (CQ00746648)
                { "246", "Separator" }
            }
        },

         // 24. Valves
        { 24, new Dictionary<string, string>
            {
                // Vavle (CQ00746646)
                { "344", "Valve" }
            }
        },

        // 25. SimpleShell&TubeHE
        { 25, new Dictionary<string, string>
            {
                // SimpleShell&TubeHE (CQ00748796)
                { "385", "HeatExchanger" },


            }
        },

        // 26. RigorousShell&TubeHE
        { 26, new Dictionary<string, string>
            {
                // RigorousShell&TubeHE (CQ00746225)
                { "455", "HeatExchanger" },

            }
        },

         // 27. RigorousAirCooledHexchanger
        { 27, new Dictionary<string, string>
            {
                // RigorousAirCooledHexchanger (CQ00745132)
                { "526", "AirCooledExchanger" },

            }
        },

        // 28. HeatCurvesHot
        { 28, new Dictionary<string, string>
            {
                // HeatCurves (CQ00747073) Hot Side -> FluidProfile 
                { "608", "HeatingCoolingCurve" },
            }
        },

        // 29. HeatCurvesCold
        { 29, new Dictionary<string, string>
            {
                // HeatCurves (CQ00747073) Cold Side -> FluidProfile 
                { "616", "HeatingCoolingCurve" }
            }
        },

        // 30. Compressor & Compressor Curves
        { 30, new Dictionary<string, string>
            {
                // Compressor (CQ00744505)
                { "657", "Compressor" },
                // Compressor Curves (CQ00744505)
                { "668", "CurveData" },
                { "669", "CurveData" },
                { "670", "CurveData" },
                { "671", "CurveData" },
                { "672", "CurveData" },
                { "673", "CurveData" },

            }
        },

         // 31. Expander
        { 31, new Dictionary<string, string>
            {
                // Expander (CQ00748768)
                { "690", "Expander" }
            }
        },

         // 32. Streams
        { 32, new Dictionary<string, string>
            {


                // Stream (CQ00730633) Uswe MaterialPort-Inlet OID
                { "726", "PipingSystem" },

            }
        },

        // 33. Vessels
        { 33, new Dictionary<string, string>

            {
                // Vessels
                //Inlet 1
                { "746", "Port" },

            }
        },

         // 34. Utility
        { 34, new Dictionary<string, string>
            {
                // Pump-Utility
                { "794", "Pump" },
                // Seperator-Utility
                { "834", "PipingSystem" },
                //// Compressor Curve-Utility
                { "839", "PipingSystem" },
                //// Deep Cut Turbo-Expander-Utility
                { "844", "PipingSystem" },
                //// Acid Gas Cleaning Using MDEA-Utility
                { "851", "PipingSystem" },
                //// Heater_Cooler-Utility
                { "856", "PipingSystem" },
                //Heater_Cooler-Utility
                { "858", "PipingSystem" },
            }
        },

        // 35. MCompressor
        { 35, new Dictionary<string, string>
            {
                // Multi-Compressors(CQ00730640)
                { "1046", "Compressor" },
            }
        },

        // 36. ColumnMainTS, use AbeAdsDistillation classview 
        { 36, new Dictionary<string, string>
            {

            // Tray Section, Trays, Column Section 
            { "1155", "TraySection" }, // Use main object OID
            { "2174", "ColumnSection" }, // In ColumnSections
        }

        },

          // 37. ColumnTS1, use AbeAdsDistillation classview 
        { 37, new Dictionary<string, string>
            {
            //TS-1 
            { "1619", "ColumnSection" }, // In ColumnSections

            }
        },


        // 38. HeaterCooler
        { 38, new Dictionary<string, string>
            {

            { "2517", "HeaterCooler" },
            { "2534", "HeaterCooler" },

            }
        },



        // ProII 

        // 39. Simple HX
        { 39, new Dictionary<string, string>
             {
                 {"236", "HeatExchanger" }
             }

         },

        // 40. Pump
        { 40, new Dictionary<string, string>
             {
                 {"332", "Pump" }
             }

         },

        // 41. Valve
        { 41, new Dictionary<string, string>
             {
                 {"220", "Valve" }
             }

         },

        // 42. Flash
        { 42, new Dictionary<string, string>
             {
                 {"150", "Separator" }
             }

         },

         // 43. Compressor
        { 43, new Dictionary<string, string>
             {
                 {"417", "Compressor" }
             }

         },

         // 44. Air Cooled HX
        { 44, new Dictionary<string, string>
             {
                 {"315", "AirCooledExchanger" }
             }

         }, 
        
        // 45. Stream
        { 45, new Dictionary<string, string>
             {
                 {"393", "PipingSystem" }
             }

         },
        // 46. Bulk Phase & Liquid Phase
        { 46, new Dictionary<string, string>
             {
                 {"429", "PipingSystem" }
             }

         },
          // 47. Vapor Phase
        { 47, new Dictionary<string, string>
             {
                 {"447", "PipingSystem" }
             }

         },   
        
        // 48 Distillation Column and Trays
        { 48, new Dictionary<string, string>
             {
                 {"14", "Distillation" }
             }

         },

        // 49 Mixer
        { 49, new Dictionary<string, string>
             {
                 {"472", "Generic" }
             }

         },

        // 50 Splitter
        { 50, new Dictionary<string, string>
             {
                 {"533", "Generic" }
             }

         },

         // 51 Pump Around
        { 51, new Dictionary<string, string>
             {
                 {"526", "Distillation" }
             }

         }, 
        
        // 52 Turbine
        { 52, new Dictionary<string, string>
             {
                 {"746", "Expander" }
             }

         },

         // 53 SideColumn
        { 53, new Dictionary<string, string>
             {
                 {"793", "Distillation" }
             }

         },

         // 54 DistillationPortData
        { 54, new Dictionary<string, string>
             {
                 {"73", "Distillation" } // CN-1 Object since this column has stream 1 and 3 data. compare these data with data in baseline for Stream and Bulk Phase & Liquid Phase
             }

         },

        // 55 ValvePortData
         { 55, new Dictionary<string, string>
             {
                 {"270", "Valve" } // V-1 Object since this column has stream 3 and 4 data. compare these data with data in baseline for Bulk Phase & Liquid Phase and VaporPhase
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

