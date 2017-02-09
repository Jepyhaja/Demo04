using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles04
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatCount { get; set; }


        public override string ToString()
        {
            return base.ToString() + " " + BoatType + " " + SeatCount;
        }


    }
}
