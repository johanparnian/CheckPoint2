using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Company
    {
        private List<Person> _employees = new();

        public string Name { get; private set; }
        public int EmployeeCount { get; set; }

        public Company(string name, int employeeCount)
        {
            Name = name;
            EmployeeCount = employeeCount;
            
        }

        public void PrintAllEmployees()
        {
            foreach (var employee in _employees)
            {
                if (employee is Employee)
                Console.WriteLine(employee.Name);
            }
        }

        public void AddEmployeeToList(Person employeeOrPerson)
        {
            _employees.Add(employeeOrPerson);
        }
    }
}
