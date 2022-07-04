using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; set; }

        public Person(string name = "N/A", int age = 0)
        {
            Name = name;
            Age = age;
        }
    }
}
