using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles04
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }



        public override string ToString()
        {
            return Name + " " + Model + " " + ModelYear + " " + Color;
        }


    }
}
