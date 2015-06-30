using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    class Move
    {
        public Areas Location;
        Areas Area0(Areas modLoc)
        {
            modLoc.areaName = "area0";
            modLoc.areaImage = "./images/area1.png";
            modLoc.areaText = "You have entered area0.";
            //            string areaNorth = "You've hit a wall.  Good job.";
            //            string areaSouth = "There's no way.";
            //            string areaWest = "There is no exit this way";
            //            string areaEast = "Just a wall.";
            //            string areaUp = "GoTo#Area1";
            //            string[] areaItems;
            //            areaItems = new string[];
            Location = modLoc;
            return modLoc;
        }
    }
}

