using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    [TestFixture]
    public class Tests
    {
        [TestCase("apple", "applema")]
        [TestCase("goat", "oatgma")]
        [TestCase("goat apple","oatgmaa applemaaa")]
        //[TestCase("!2c-1fj", "!2j-1fc")]
        public void CheckTranslate(string input, string output)
        {
            //Act
            var actual = GoatLatin.Translate(input);

            //Assert
            Assert.AreEqual(output, actual);
        }

        [Test]
        public void CheckNull()
        {
            //Assert
            Assert.Throws<ArgumentNullException>(
               () => GoatLatin.Translate(null));
        }


    }
}
