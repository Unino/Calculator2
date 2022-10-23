using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator2;

namespace CalculatorTesting
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal ;
        [TestInitialize]
        public void SetUp()
        {//10 + 5 ->15            
            cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOpertor()
        {//10 + 5 ->15            
            Assert.AreEqual(15, cal.Execute("+"));
        }
        [TestMethod]
        public void TestSubOpertor()
        {//10 + 5 ->15
            Assert.AreEqual(5, cal.Execute("-"));
        }
        [TestMethod]
        public void TestMulOpertor()
        {//10 + 5 ->15
            Assert.AreEqual(50, cal.Execute("*"));
        }
        [TestMethod]
        public void TestDivOpertor()
        {//10 + 5 ->15
            Assert.AreEqual(2, cal.Execute("/"));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {//10 + 5 ->15
            Calculation c = new Calculation(10,0);
            c.Execute("/");
        }
    }
}
