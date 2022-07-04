using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Company
    {
        public string Name { get; set; }
        public int EmployeeCount { get; set; }

        public Company(int employeeCount, string name = "N/A")
        {
            Name = name;
            EmployeeCount = employeeCount;
        }
    }
}
