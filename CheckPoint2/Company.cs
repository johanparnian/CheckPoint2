using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Company
    {
        List<Employee> _employees;

        public string Name { get; private set; }
        public int EmployeeCount { get; set; }

        public Company(string name, int employeeCount)
        {
            Name = name;
            EmployeeCount = employeeCount;
        }
    }
}
