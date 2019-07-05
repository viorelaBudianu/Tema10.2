using Calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBonusNuget
{
    class TestCalculatorMathNuget
    {
        private Matrix<double> matrice1, matrice2;

        [SetUp]
        public void Init()
        {
            matrice1 = new Matrix<double>(8, 8, new double[] { 2, 12.2, 21.2, 3, 2, 1, 4, 9 });
            matrice2 = new Matrix<double>(8, 8, new double[] { 32, 2, 45.3, 32, 32.4, 5, 9, 10 });


        }
        [Test]
        public void CheckAdunareMatrice()
        {
            Init();
            //act
            var actual = CalculatorGenericMath.Add<Matrix<double>>(matrice1, matrice2);

            var expected = matrice1 + matrice2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckScadereMatrice()
        {
            Init();
            //act
            var actual = CalculatorGenericMath.Subtract(matrice1, matrice2);
            var expected = matrice1 - matrice2;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckInmultireMatrice()
        {
            Init();
            //act
            var actual = CalculatorGenericMath.Multiply(matrice1, matrice2);
            var expected = matrice2 * matrice1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckImpartireMatrice()
        {
            Init();
            //act
            var expected = matrice1 / matrice2;
            var actual = CalculatorGenericMath.Divide(matrice1, matrice2);

            Assert.AreEqual(expected, actual);
        }
    }
}
