using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialString
{
    [TestFixture]
   public class Test
    {
        [TestCase("abc-1fj", "jfc-1ba")]        
        [TestCase("1234a", "1234a")]
        [TestCase("!2c-1fj", "!2j-1fc")]
        public void CheckReverse(string input, string output)
        {
            //Act
            var actual = ReverseSpecialString.reverseSpecial(input);

            //Assert
            Assert.AreEqual(output, actual);
        }

        [Test]
        public void CheckNull()
        {
           //Assert
            Assert.Throws<ArgumentNullException>(
               () => ReverseSpecialString.reverseSpecial(null));
        }


    }
}
