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
            Person P1 = new(name, age);

            if (P1.Name == name && P1.Age == age)
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
            Employee E1 = new(name, age, hireDate);


            if (E1.Name == name && E1.Age == age && hireDate == E1.HireDate)  
            {
                check = true;
            }

            Assert.IsTrue(check);
            // Her kan DateTime.Now i actual og expected være bittelitt ulik hvis testen utføres litt tregt (tror jeg).
            // Så jeg burde heller ha satt faste tider.
        }

    }
}