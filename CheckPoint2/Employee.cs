using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Employee : Person, IEmployeeCounter
    {
        public DateTime HireDate { get; private set; }

        public Employee(string name, int age, DateTime hireDate, Company company) : base(name, age, company)
        {
            HireDate = hireDate;
            EmployeeCounter(company);
        }

        public void EmployeeCounter(Company company)
        {
          company.EmployeeCount++;
        }
    }
}
