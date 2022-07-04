using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Employee : Person
    {
        public string HireDate { get; private set; }

        public Employee(string name, int age, string hireDate) : base(name, age)
        {
            HireDate = hireDate;
        }   
    }
}
