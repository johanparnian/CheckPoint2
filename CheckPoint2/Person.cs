using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Person //Denne ville jeg gjort abstract om ikke det var for Unit-testingen. 
    {
        public string Name { get; private set; }
        public int Age { get; set; }
        public Company Company { get; private set; }

        public Person(string name, int age, Company company)
        {
            Name = name;
            Age = age;
            Company = company;
        }
    }
}
