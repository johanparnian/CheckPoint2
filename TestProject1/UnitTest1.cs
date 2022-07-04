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

            if (C1.Name == "aw" && C1.EmployeeCount==50)
            {
                check = true;
            }
            
            Assert.IsTrue(check);
        }


    }
}