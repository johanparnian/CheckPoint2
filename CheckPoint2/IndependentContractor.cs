using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint2
{
    public class IndependentContractor : Person
    {
        public DateTime HireDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int ContractValue { get; private set; }


        public IndependentContractor(string name, int age, DateTime hireDate, DateTime endDate) : base(name, age)
        {
            HireDate = hireDate;
            EndDate = endDate;
        }


    }
}
