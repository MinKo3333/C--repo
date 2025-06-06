using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Debugging_NUnit
{   
    [TestFixture]
    internal class CalculatorTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calc = new Calculator();

            //Act
            int result = calc.Add(3, 5);

            //Assert
            Assert.AreEqual(8, result);
        }
    }
}
