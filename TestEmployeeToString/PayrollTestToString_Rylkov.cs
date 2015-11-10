using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll_Rylkov;

namespace TestEmployeeToString
{
    [TestClass]
    public class PayrollTestToString_Rylkov
    {
        [TestMethod]
        public void TestEmployeeToString()
        {
            int empId = 1;
            Employee e = new Employee(empId, "Bob", "Home");
            Assert.AreEqual("Bob", e.Name);
            Assert.AreEqual("Home", e.Address);
            Assert.AreEqual(empId, e.EmpId);
        }
        
    }
}
