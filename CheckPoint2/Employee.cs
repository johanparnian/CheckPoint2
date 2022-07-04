using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Employee : Person
    {
        public DateTime HireDate { get; private set; }


        public Employee(string name, int age, DateTime hireDate) : base(name, age)
        {
            HireDate = hireDate;
        }


    }
}
