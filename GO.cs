using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    public class GO
    {
        public static void goTo(string input)
        {
            bool moved = true;
            Form1.cmdToUI.imageOutput = "true";
            if (input == "area0")
            {
                MoveLoc.area0();
            }
            else if (input == "area1")
            {
                MoveLoc.area1();
            }
            else if (input == "area2")
            {
                MoveLoc.area2();
            }
            else if (input == "area3")
            {
                MoveLoc.area3();
            }
            else if (input == "area4")
            {
                MoveLoc.area4();
            }
            else if (input == "area5")
            {
                MoveLoc.area5();
            }
            else if (input == "area6")
            {
                MoveLoc.area6();
            }
            else
            {
                Form1.cmdToUI.imageOutput = "false";
                moved = false;

            }
            if (moved == true)
            {
                Form1.cmdToUI.textOutput = Form1.Loc.areaText;
            }
            else
            {
                Form1.cmdToUI.textOutput = input;
            }
        }

        public static string direction(string input)
        {
            string output = "";
            if (input.Contains("NORTH"))
            {
                output = Form1.Loc.areaNorth;
            }
            else if (input.Contains("SOUTH"))
            {
                output = Form1.Loc.areaSouth;
            }
            else if (input.Contains("EAST"))
            {
                output = Form1.Loc.areaEast;
            }
            else if (input.Contains("WEST"))
            {
                output = Form1.Loc.areaWest;
            }
            else if (input.Contains("UP"))
            {
                output = Form1.Loc.areaUp;
            }
            else if (input.Contains("DOWN"))
            {
                output = Form1.Loc.areaDown;
            }
            else
            {
                output = "error";
            }
            return output;
        }
    }
}
