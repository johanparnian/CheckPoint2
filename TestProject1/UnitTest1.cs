using CheckPoint2;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCompanyInstance()
        {
            bool check = false;
            Company C1 = new("aw", 50);

            if (C1.Name == "aw" && C1.EmployeeCount == 50)
            {
                check = true;
            } 

            Assert.IsTrue(check);
        }

        [Test]
        public void TestPersonInstance()
        {
            bool check = false;
            string name = "Aladding";
            int age = 18;
            Company C1 = new("aw", 42);
            Person P1 = new(name, age, C1);

            if (P1.Name == name && P1.Age == age && P1.Company == C1)
            {
                check = true;
            }

            Assert.IsTrue(check);
        }

        [Test]
        public void TestEmployeeInstance()
        {
            bool check = false;
            string name = "Johan";
            int age = 34;
            DateTime hireDate = DateTime.Now;
            Company C1 = new("aw", 42);
            Employee E1 = new(name, age, hireDate, C1);


            if (E1.Name == name && E1.Age == age && hireDate == E1.HireDate && E1.Company == C1)  
            {
                check = true;
            }

            Assert.IsTrue(check);
            // Her kan DateTime.Now i actual og expected være bittelitt ulik hvis testen utføres litt tregt (tror jeg).
            // Så jeg burde heller ha satt faste tider.
        }

    }
}