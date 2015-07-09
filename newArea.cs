using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    class MoveLoc
    {
        public static void Intro()
        {
            Form1.Loc.areaName = "Intro";
            Form1.Loc.areaText = "Welcome.";
            Form1.Loc.areaDesc = "There is no description.";
            Form1.Loc.areaNorth = "You've hit a wall.  Good job.";
            Form1.Loc.areaSouth = "There's no way.";
            Form1.Loc.areaWest = "There is no exit this way";
            Form1.Loc.areaEast = "Just a wall.";
            Form1.Loc.areaUp = "area0";
            Form1.Loc.areaDown = "Nothing down there.";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area0()
        {
            Form1.Loc.areaName = "area0";
            Form1.Loc.areaText = "You have entered area 0 (Cata). (Ladder Up)";
            Form1.Loc.areaDesc = "A shovel lies on the ground.  A ladder runs up the wall.";
            Form1.Loc.areaNorth = "You've hit a wall.  Good job.";
            Form1.Loc.areaSouth = "There's no way.";
            Form1.Loc.areaWest = "There is no exit this way";
            Form1.Loc.areaEast = "Just a wall.";
            Form1.Loc.areaUp = "area1";
            Form1.Loc.areaDown = "Just the floor.";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area1()
        {
            Form1.Loc.areaName = "area1";
            Form1.Loc.areaText = "You have entered area 1 (GY). (Path East)";
            Form1.Loc.areaDesc = "A graveyard.  Path runs East.";
            Form1.Loc.areaNorth = "You've hit a wall.  Good job.";
            Form1.Loc.areaSouth = "There's no way.";
            Form1.Loc.areaWest = "There is no exit this way";
            Form1.Loc.areaEast = "area2";
            Form1.Loc.areaUp = "You reach to the sky.";
            Form1.Loc.areaDown = "area0";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area2()
        {
            Form1.Loc.areaName = "area2";
            Form1.Loc.areaText = "You have entered area 2 (Road). (Path N, S, E, W)";
            Form1.Loc.areaDesc = "This road runs North to South and splits East.  A dreary graveyard lies to the west.";
            Form1.Loc.areaNorth = "area3";
            Form1.Loc.areaSouth = "area5";
            Form1.Loc.areaWest = "area1";
            Form1.Loc.areaEast = "area4";
            Form1.Loc.areaUp = "You reach to the sky.";
            Form1.Loc.areaDown = "Asphalt";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area3()
        {
            Form1.Loc.areaName = "area3";
            Form1.Loc.areaText = "You have entered area 3.";
            Form1.Loc.areaDesc = "This severly unkempt road is barely held together ";
            Form1.Loc.areaNorth = "You've hit a wall.  Good job.";
            Form1.Loc.areaSouth = "area2";
            Form1.Loc.areaWest = "There is no exit this way";
            Form1.Loc.areaEast = "Just a wall.";
            Form1.Loc.areaUp = "You reach to the sky.";
            Form1.Loc.areaDown = "Asphalt";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area4()
        {
            Form1.Loc.areaName = "area4";
            Form1.Loc.areaText = "You have entered area 4.";
            Form1.Loc.areaNorth = "area6";
            Form1.Loc.areaSouth = "There's no way.";
            Form1.Loc.areaWest = "area2";
            Form1.Loc.areaEast = "I'm sure something will be there someday...";
            Form1.Loc.areaUp = "You reach to the sky.";
            Form1.Loc.areaDown = "Asphalt";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area5()
        {
            Form1.Loc.areaName = "area5";
            Form1.Loc.areaText = "You have entered area 5.";
            Form1.Loc.areaNorth = "area2";
            Form1.Loc.areaSouth = "There's no way.";
            Form1.Loc.areaWest = "There is no exit this way";
            Form1.Loc.areaEast = "Just a wall.";
            Form1.Loc.areaUp = "You reach to the sky.";
            Form1.Loc.areaDown = "Asphalt";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area6()
        {
            Form1.Loc.areaName = "area6";
            Form1.Loc.areaText = "You have entered area 6.";
            Form1.Loc.areaNorth = "You've hit a wall.  Good job.";
            Form1.Loc.areaSouth = "area4";
            Form1.Loc.areaWest = "There is no exit this way";
            Form1.Loc.areaEast = "Just a wall.";
            Form1.Loc.areaUp = "You reach to the sky.";
            Form1.Loc.areaDown = "Looks like wood, but feels like concrete.";
            //            string[] areaItems;
            //            areaItems = new string[];
        }
    }
}
