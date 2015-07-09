using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    public class Areas {
        public string areaName { get; set; }
        public string areaText { get; set; }
        public string areaDesc { get; set; }
        public string areaNorth { get; set; }
        public string areaSouth { get; set; }
        public string areaEast { get; set; }
        public string areaWest { get; set; }
        public string areaUp { get; set; }
        public string areaDown { get; set; }
//        public string[] areaItems { get; set; }
//        public string[] areaNPCs { get; set; }

        public Areas(string areaName, string areaText, string areaDesc, string areaNorth, string areaSouth, string areaEast, string areaWest, string areaUp, string areaDown/*, string[] areaItems, string[] areaNPCs*/)
        {
            this.areaName = areaName;
            this.areaText = areaText;
            this.areaNorth = areaNorth;
            this.areaSouth = areaSouth;
            this.areaEast = areaEast;
            this.areaWest = areaWest;
            this.areaUp = areaUp;
            this.areaDown = areaDown;
//            this.areaItems = areaItems;
//            this.areaNPCs = areaNPCs;
        }
    }
}
