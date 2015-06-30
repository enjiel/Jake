using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    public class Areas {
        public string areaName { get; set; }
        public string areaImage { get; set; }
        public string areaText { get; set; }
//        public string areaDesc { get; set; }
//        public string areaNorth { get; set; }
//        public string areaSouth { get; set; }
//        public string areaEast { get; set; }
//        public string areaWest { get; set; }
//        public string areaUp { get; set; }
//        public string areaDown { get; set; }
//        public string[] areaItems { get; set; }
//        public string[] areaNPCs { get; set; }

        public Areas(string areaName, string areaImage, string areaText /*, string areaDesc, string areaNorth, string areaSouth, string areaEast, string areaWest, string areaUp, string areaDown, string[] areaItems, string[] areaNPCs*/)
        {
            areaName = areaName;
            areaImage = areaImage;
            areaText = areaText;
//            areaNorth = areaNorth;
//            areaSouth = areaSouth;
//            areaEast = areaEast;
//            areaWest = areaWest;
//            areaUp = areaUp;
//            areaDown = areaDown;
//            areaItems = areaItems;
//            areaNPCs = areaNPCs;
        }

        public static void Area0() {
            string areaName = "area0";
            string areaImage = "./images/area1.png";
            string areaText = "You have entered area0.";
//            string areaNorth = "You've hit a wall.  Good job.";
//            string areaSouth = "There's no way.";
//            string areaWest = "There is no exit this way";
//            string areaEast = "Just a wall.";
//            string areaUp = "GoTo#Area2";
//            string[] areaItems;
//            areaItems = new string[];
            return areaName, areaImage, areaText;
        }
    }
}
