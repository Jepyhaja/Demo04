using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles04
{
    class Bike : Vehicle
    {
        public bool GearWheel { get; set; }
        public string GearType { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + GearWheel + " " + GearType;
        }




    }
}
