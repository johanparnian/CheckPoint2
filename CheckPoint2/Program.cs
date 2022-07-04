using System;

namespace CheckPoint2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Company company = new("AW", 100);

            Person someGuy = new("Alladin", 20, company);
            company.AddEmployeeToList(someGuy);

            Employee e1 = new("Johan", 33, DateTime.Now, company);
            company.AddEmployeeToList(e1);

            company.PrintAllEmployees();


        }
    }
}