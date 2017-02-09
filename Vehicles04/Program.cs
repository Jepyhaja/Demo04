using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.Name = "Tunturi";
            bike.Model = "Kayapo";
            bike.ModelYear = 1998;
            bike.GearWheel = true;
            bike.GearType = "24-gears";

            Console.WriteLine(bike.ToString());


            Boat boat = new Boat();
            boat.Name = "Noora";
            boat.Model = "Bella";
            boat.ModelYear = 1982;
            boat.Color = "Mahogany";
            boat.SeatCount = 16;
            boat.BoatType = "M/S";
            Console.WriteLine(boat.ToString());
            




        }
    }
}
