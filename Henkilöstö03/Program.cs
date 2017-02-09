using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henkilöstö03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kaisa = new Employee();
            kaisa.FirstName = "Kaisa";
            kaisa.LastName = "Kernel";
            kaisa.Profession = "Teacher";
            kaisa.Salary = 3000;
            Console.WriteLine(kaisa.ToString());


            Boss jussi = new Boss();
            jussi.FirstName = "Jussi";
            jussi.LastName = "Jurkka";
            jussi.Profession = "Head of institute";
            jussi.Salary = 8000;
            jussi.Car = "Maserati";
            jussi.Bonus = 2000;
            Console.WriteLine(jussi.ToString());



        }
    }
}
