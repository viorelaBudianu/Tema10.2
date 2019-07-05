using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    class TestGenerics
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
            var actual = CalculatorBonus<Matrix<double>>.Add(matrice1, matrice2);

            var expected = matrice1 + matrice2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckScadereMatrice()
        {
            Init();
            //act
            var actual = CalculatorBonus<Matrix<double>>.Sub(matrice1, matrice2);
            var expected = matrice1 - matrice2;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckInmultireMatrice()
        {
            Init();
            //act
            var actual = CalculatorBonus<Matrix<double>>.Multiplication(matrice1, matrice2);
            var expected = matrice2 * matrice1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckImpartireMatrice()
        {
            Init();
            //act
            var expected = matrice1/ matrice2;
            var actual = CalculatorBonus<Matrix<double>>.Division(matrice1, matrice2);

            Assert.AreEqual(expected, actual);
        }
    }

}
