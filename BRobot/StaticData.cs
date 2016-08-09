﻿////███████╗████████╗ █████╗ ████████╗██╗ ██████╗██████╗  █████╗ ████████╗ █████╗ 
////██╔════╝╚══██╔══╝██╔══██╗╚══██╔══╝██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗
////███████╗   ██║   ███████║   ██║   ██║██║     ██║  ██║███████║   ██║   ███████║
////╚════██║   ██║   ██╔══██║   ██║   ██║██║     ██║  ██║██╔══██║   ██║   ██╔══██║
////███████║   ██║   ██║  ██║   ██║   ██║╚██████╗██████╔╝██║  ██║   ██║   ██║  ██║
////╚══════╝   ╚═╝   ╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝


//namespace BRobot
//{
//    internal class StaticData
//    {

//        /// <summary>
//        /// The standard module used for ABB Online Stream mode
//        /// </summary>
//        public static string[] StreamModule =
//        {
//            "MODULE StreamModule",
//            "",
//            //"  ! Table collision prevention",
//            //"  VAR wzstationary table_box;",
//            //"",
//            "  PERS bool aborted := FALSE;",
//            "  PERS num pnum := -1;",
//            "",
//            "  PERS speeddata vel0:=[20,20,1000,1000];",
//            "  PERS speeddata vel1:=[20,20,1000,1000];",
//            "  PERS speeddata vel2:=[20,20,1000,1000];",
//            "  PERS speeddata vel3:=[20,20,1000,1000];",
//            "",
//            "  PERS zonedata zone0:=[FALSE,5,8,8,0.8,8,0.8];",
//            "  PERS zonedata zone1:=[FALSE,5,8,8,0.8,8,0.8];",
//            "  PERS zonedata zone2:=[FALSE,5,8,8,0.8,8,0.8];",
//            "  PERS zonedata zone3:=[FALSE,5,8,8,0.8,8,0.8];",
//            "",
//            "  PERS bool pset0 := FALSE;",
//            "  PERS bool pset1 := FALSE;",
//            "  PERS bool pset2 := FALSE;",
//            "  PERS bool pset3 := FALSE;",
//            "",
            
//            "  PERS robtarget p0 := [[377.22,4.21,546.99],[0,-0.0056,1,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS robtarget p1 := [[260.33,4.21,671.48],[0,-0.0081,1,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS robtarget p2 := [[128.75,4.21,562.63],[0,-0.0163,0.9999,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS robtarget p3 := [[229.12,4.21,424.47],[0,-0.0092,1,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "",
//            "  PERS jointtarget home1 := [[1,1,1,1,1,30],[9E9,9E9,9E9,9E9,9E9,9E9]];  ! small rots to avoid singularity problems",
//            "",
//            "  PROC main()",
//            "    AccSet 10, 10;",
//            "    ConfL\\Off;",
//            "    ConfJ\\Off;",
//            //"    wzone_power_on;",
//            "",
//            "    ! MoveAbsJ home1,vel0,zone0,Tool0\\WObj:=WObj0;",
//            "    Path0;",
//            "  ENDPROC",
//            "",
//            "  PROC Path0()",
//            "    WHILE NOT aborted DO",
//            "      WaitUntil pset0 = TRUE;",
//            "      pset0 := FALSE;",
//            "      pnum := 0;",
//            "      MoveL p0,vel0,zone0,Tool0\\WObj:=WObj0;",
//            "",
//            "      WaitUntil pset1 = TRUE;",
//            "      pset1 := FALSE;",
//            "      pnum := 1;",
//            "      MoveL p1,vel1,zone1,Tool0\\WObj:=WObj0;",
//            "",
//            "      WaitUntil pset2 = TRUE;",
//            "      pset2 := FALSE;",
//            "      pnum := 2;",
//            "      MoveL p2,vel2,zone2,Tool0\\WObj:=WObj0;",
//            "",
//            "      WaitUntil pset3 = TRUE;",
//            "      pset3 := FALSE;",
//            "      pnum := 3;",
//            "      MoveL p3,vel3,zone3,Tool0\\WObj:=WObj0;",
//            "    ENDWHILE",
//            "  ENDPROC",
//            "",
//            //"  PROC wzone_power_on()",
//            //"    VAR shapedata volume;",
//            //"    CONST pos table_low:=[-1000, -1000, -100];",
//            //"    CONST pos table_high:=[1000, 1000, 25];",
//            //"    WZBoxDef \\Inside, volume, table_low, table_high;",
//            //"    WZLimSup \\Stat, table_box, volume;",
//            //"  ENDPROC",
//            //"",
//            "ENDMODULE"
//        };

//        /// <summary>
//        /// The enhanced module used for ABB Online Stream mode
//        /// </summary>
//        public static string[] StreamModuleV2 =
//        {
//            "MODULE StreamModule",
//            "",
//            "  ! \"Global\" flags",
//            "  PERS bool aborted := FALSE;",
//            "  PERS num pnum := -1;",
//            "",
//            "  ! Step flags",
//            "  PERS bool pset0 := FALSE;",
//            "  PERS bool pset1 := FALSE;",
//            "  PERS bool pset2 := FALSE;",
//            "  PERS bool pset3 := FALSE;",
//            "",
//            "  ! Action flags",
//            "  PERS num act0 := 0;",
//            "  PERS num act1 := 0;",
//            "  PERS num act2 := 0;",
//            "  PERS num act3 := 0;",
//            "",
//            "  ! Speed declarations",
//            "  PERS speeddata vel0 := [20,20,1000,1000];",
//            "  PERS speeddata vel1 := [20,20,1000,1000];",
//            "  PERS speeddata vel2 := [20,20,1000,1000];",
//            "  PERS speeddata vel3 := [20,20,1000,1000];",
//            "",
//            "  ! Zone declarations",
//            "  PERS zonedata zone0 := [FALSE,5,8,8,0.8,8,0.8];",
//            "  PERS zonedata zone1 := [FALSE,5,8,8,0.8,8,0.8];",
//            "  PERS zonedata zone2 := [FALSE,5,8,8,0.8,8,0.8];",
//            "  PERS zonedata zone3 := [FALSE,5,8,8,0.8,8,0.8];",
//            "",
//            "  ! RobTarget declarations",
//            "  PERS robtarget rt0 := [[1000, 0, 500],[0,0,1,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS robtarget rt1 := [[1000, 0, 500],[0,0,1,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS robtarget rt2 := [[1000, 0, 500],[0,0,1,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS robtarget rt3 := [[1000, 0, 500],[0,0,1,0],[0,0,0,0],[0,9E9,9E9,9E9,9E9,9E9]];",
//            "",
//            "  ! JonumTarget declarations",
//            "  PERS jonumtarget jt0 := [[0,0,0,0,90,0],[9E9,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS jonumtarget jt1 := [[0,0,0,0,90,0],[9E9,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS jonumtarget jt2 := [[0,0,0,0,90,0],[9E9,9E9,9E9,9E9,9E9,9E9]];",
//            "  PERS jonumtarget jt3 := [[0,0,0,0,90,0],[9E9,9E9,9E9,9E9,9E9,9E9]];",
//            "",
//            "  ! Waittimes",
//            "  PERS num wt0 := 0;",
//            "  PERS num wt1 := 0;",
//            "  PERS num wt2 := 0;",
//            "  PERS num wt3 := 0;",
//            "",
//            "  ! Messages",
//            "  PERS string msg0 := \"foo\";",
//            "  PERS string msg1 := \"bar\";",
//            "  PERS string msg2 := \"baz\";",
//            "  PERS string msg3 := \"qux\";",
//            "",
//            "",
//            "  PROC main()",
//            "    AccSet 10, 10;",
//            "    ConfL\\Off;",
//            "    ConfJ\\Off;",
//            "",
//            "    Path0;",
//            "  ENDPROC",
//            "",
//            "  PROC Path0()",
//            "    WHILE NOT aborted DO",
//            "      WaitUntil pset0 = TRUE;",
//            "      pset0 := FALSE;",
//            "      pnum := 0;",
//            "      TEST act0",
//            "        CASE 1:",
//            "          MoveL rt0,vel0,zone0,Tool0\\WObj:=WObj0;",
//            "        CASE 2:",
//            "          MoveJ rt0,vel0,zone0,Tool0\\WObj:=WObj0;",
//            "        CASE 3:",
//            "          MoveAbsJ jt0,vel0,zone0,Tool0\\WObj:=WObj0;",
//            "        CASE 4:",
//            "          WaitTime wt0;",
//            "        CASE 5:",
//            "          TPWrite msg0;",
//            "      ENDTEST",
//            "",
//            "      WaitUntil pset1 = TRUE;",
//            "      pset1 := FALSE;",
//            "      pnum := 1;",
//            "      TEST act1",
//            "        CASE 1:",
//            "          MoveL rt1,vel1,zone1,Tool0\\WObj:=WObj0;",
//            "        CASE 2:",
//            "          MoveJ rt1,vel1,zone1,Tool0\\WObj:=WObj0;",
//            "        CASE 3:",
//            "          MoveAbsJ jt1,vel1,zone0,Tool0\\WObj:=WObj0;",
//            "        CASE 4:",
//            "          WaitTime wt1;",
//            "        CASE 5:",
//            "          TPWrite msg1;",
//            "      ENDTEST",
//            "",
//            "      WaitUntil pset2 = TRUE;",
//            "      pset2 := FALSE;",
//            "      pnum := 2;",
//            "      TEST act2",
//            "        CASE 1:",
//            "          MoveL rt2,vel2,zone2,Tool0\\WObj:=WObj0;",
//            "        CASE 2:",
//            "          MoveJ rt2,vel2,zone2,Tool0\\WObj:=WObj0;",
//            "        CASE 3:",
//            "          MoveAbsJ jt2,vel2,zone2,Tool0\\WObj:=WObj0;",
//            "        CASE 4:",
//            "          WaitTime wt2;",
//            "        CASE 5:",
//            "          TPWrite msg2;",
//            "      ENDTEST",
//            "",
//            "      WaitUntil pset3 = TRUE;",
//            "      pset3 := FALSE;",
//            "      pnum := 3;",
//            "      TEST act3",
//            "        CASE 1:",
//            "          MoveL rt3,vel3,zone3,Tool0\\WObj:=WObj0;",
//            "        CASE 2:",
//            "          MoveJ rt3,vel3,zone3,Tool0\\WObj:=WObj0;",
//            "        CASE 3:",
//            "          MoveAbsJ jt3,vel3,zone3,Tool0\\WObj:=WObj0;",
//            "        CASE 4:",
//            "          WaitTime wt3;",
//            "        CASE 5:",
//            "          TPWrite msg3;",
//            "      ENDTEST",
//            "",
//            "    ENDWHILE",
//            "  ENDPROC",
//            "",
//            "ENDMODULE"
//        };
//    }

//}
