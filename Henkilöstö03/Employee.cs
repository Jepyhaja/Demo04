using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henkilöstö03
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        //cons
        public Employee()
        { 

        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Profession + " " + Salary;
        }



    }
}
