namespace ThalesAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmployeeAnualSalary()

        {
            int result = new ThalesApp.Models.EmployeeModel() { Employee_Salary = 100 }.Employee_Anual_Salary;
            Assert.AreEqual(1200, result);
        }
    }
}