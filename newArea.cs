using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    class Move
    {
        /*
        public Areas Intro()
        {
            modLoc.areaName = "Intro";
            modLoc.areaImage = "Intro";
            modLoc.areaText = "Welcome.";
            // modLoc.areaNorth = "You've hit a wall.  Good job.";
            // modLocareaSouth = "There's no way.";
            //            string areaWest = "There is no exit this way";
            //            string areaEast = "Just a wall.";
            modLoc.areaUp = "area0";
            modLoc.areaDown = "Nothing down there.";
            //            string[] areaItems;
            //            areaItems = new string[];
            return modLoc;
        }
        */
        public static void area0()
        {
            Form1.Loc.areaName = "area0";
            Form1.Loc.areaText = "You have entered area 0.";
            //            string areaNorth = "You've hit a wall.  Good job.";
            //            string areaSouth = "There's no way.";
            //            string areaWest = "There is no exit this way";
            //            string areaEast = "Just a wall.";
            Form1.Loc.areaUp = "area1";
            Form1.Loc.areaDown = "Just the floor.";
            //            string[] areaItems;
            //            areaItems = new string[];
        }

        public static void area1()
        {
            Form1.Loc.areaName = "area1";
            Form1.Loc.areaText = "You have entered area 1.";
            //            string areaNorth = "You've hit a wall.  Good job.";
            //            string areaSouth = "There's no way.";
            //            string areaWest = "There is no exit this way";
            //            string areaEast = "Just a wall.";
            Form1.Loc.areaUp = "You reach to the sky.";
            Form1.Loc.areaDown = "area0";
            //            string[] areaItems;
            //            areaItems = new string[];
        }
        /*
        public static Areas area2(Areas modLoc)
        {
            modLoc.areaName = "area2";
            modLoc.areaImage = "./images/area2.png";
            modLoc.areaText = "You have entered area 2.";
            //            string areaNorth = "You've hit a wall.  Good job.";
            //            string areaSouth = "There's no way.";
            //            string areaWest = "There is no exit this way";
            //            string areaEast = "Just a wall.";
            //            string areaUp = "GoTo#Area1";
            //            string[] areaItems;
            //            areaItems = new string[];
            return modLoc;
        }

        public static Areas area3(Areas modLoc)
        {
            modLoc.areaName = "area3";
            modLoc.areaImage = "./images/area3.png";
            modLoc.areaText = "You have entered area 3.";
            //            string areaNorth = "You've hit a wall.  Good job.";
            //            string areaSouth = "There's no way.";
            //            string areaWest = "There is no exit this way";
            //            string areaEast = "Just a wall.";
            //            string areaUp = "GoTo#Area1";
            //            string[] areaItems;
            //            areaItems = new string[];
            return modLoc;
        }
         */
    }
}
