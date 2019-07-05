using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorSimplu
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void CheckAdunare()
        {
            //Arrange
            double input1 = 21.9;
            double input2 = 29.08;

            //Act
            var actual = Calculator.Adunare(input1,input2);

            //Assert
            Assert.AreEqual(50.98, actual);
        }

        [TestCase(32.8, 0,32.8)]
        [TestCase(987.54, 1235.76,2223.3)]
        [TestCase(-986.654, 564.99,-421.664)]
        [TestCase(-76.0,-0.53,-76.53)]        

        public void CheckAdunare2(double input, double input1, double output)
        {
            //Act
            var actual = Calculator.Adunare(input,input1);

            //Assert
            Assert.AreEqual(output, actual);
        }

        [Test]
        public void CheckScadere()
        {
            //Arrange
            double input1 = 91.9;
            double input2 = -29.08;

            //Act
            var actual = Calculator.Scadere(input1, input2);

            //Assert
            Assert.AreEqual(120.98, actual,2);
        }

        [TestCase(32.8, 0, 32.8)]
        [TestCase(987.54, 1235.76, -248.22)]
        [TestCase(-986.654, 564.99, -1551.64)]
        [TestCase(-76.0, -0.53, -75.46)]

        public void CheckScadere2(double input, double input1, double output)
        {
            //Act
            var actual = Calculator.Scadere(input, input1);

            //Assert
            Assert.AreEqual(output, actual,2);
        }

        [TestCase(32.8, 0, 0)]
        [TestCase(987.54, 1235.76, 1220362.43)]
        [TestCase(-986.654, 564.99, -557449.64)]
        [TestCase(-76.0, -0.53, 40.28)]

        public void CheckInmultire(double input, double input1, double output)
        {
            //Act
            var actual = Calculator.Inmultire(input, input1);

            //Assert
            Assert.AreEqual(output, actual, 2);
        }

        [TestCase(32.8, 0, 0)]
        [TestCase(987.54, 1235.76, 1220362.43)]
        [TestCase(-986.654, 564.99, -557449.64)]
        [TestCase(-76.0, -0.53, 40.28)]

        public void CheckImpartire(double input, double input1, double output)
        {
            //Act
            var actual = Calculator.Inmultire(input, input1);

            //Assert
            Assert.AreEqual(output, actual, 2);
        }

    }
}
