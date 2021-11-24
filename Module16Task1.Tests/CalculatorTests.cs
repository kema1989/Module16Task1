using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Module16Task1.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        public Calculator calculator = new Calculator();
        // Или все же лучше внутри каждого тестового метода создавать объект типа Calculator?

        [Test]
        public void AdditionMustReturnCorrectValue()
        {
            Assert.That(calculator.Addition(22, 33) == 55);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Assert.That(calculator.Subtraction(6, -6) == 12);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            Assert.That(calculator.Multiplication(7 + 7, 8 - 5) == 42);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Assert.That(calculator.Division(67 * 77, 77) == 67);
        }

        [Test]
        public void DivisionMustThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(9 + 9, 9 - 9));
        }
    }
}
