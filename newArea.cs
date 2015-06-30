using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jake
{
    class newArea //Class for modifying the object
    {
        public Areas Location; //Using the object "Location" from the constructor "Areas"

        public void updateMe(Areas newLoc) //Get the new Location parameters and save them (see line 34)
        {
            Location = newLoc; //Save modifications to the Location object
        }
    }

    class Move //Here is where we decide what changes will be made
    {
        Areas Area0(Areas Location) //Get the old location, Modify object parameters, then return new parameters
        {
              //modify parameters
            Location.areaName = "area0";
            Location.areaImage = "./images/area1.png";
            Location.areaText = "You have entered area0.";
            //            string areaNorth = "You've hit a wall.  Good job.";
            //            string areaSouth = "There's no way.";
            //            string areaWest = "There is no exit this way";
            //            string areaEast = "Just a wall.";
            //            string areaUp = "GoTo#Area1";
            //            string[] areaItems;
            //            areaItems = new string[];
              //instantiate newArea() class
            newArea loc = new newArea();
              //Update the new location
            loc.updateMe(Location);
              //return the new location object to the form
            return Location;
        }
    }
}
