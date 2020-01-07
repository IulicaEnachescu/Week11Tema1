using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GoatLatin;

namespace GoatLatinTest
{   [TestFixture]
    
    public class Class1
    {   
        private GoatLatin.GoatLatin txt;
        [SetUp]
        public void SetUp()
        {
            txt = new GoatLatin.GoatLatin();
        }

        [Test]
        [TestCase("apple", "applemaa")]
        [TestCase("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [TestCase("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa" +
            " rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
        
        public void Should_Return_GoatLatinString(string input, string expected)
        {
            //arrange
            //act
            //GoatLatin.GoatLatin txt = new GoatLatin.GoatLatin();
            string actual =txt.GoatLatinString(input);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void Should_Throw_An_Exeption_When_Null_Or_Empty()
        {
            string input = null;
            Assert.Throws<ArgumentNullException>(() => txt.GoatLatinString(input));
        }

    }
}
