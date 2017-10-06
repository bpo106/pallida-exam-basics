using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UniqueChars;

namespace UniqueCharsTest
{
    [TestFixture]
    public class UniqueCharsTest
    {
        [Test]
        public void TestNoUniqueChars ()
        {
            var uniquechars = new UniqueCharacter();
            var list = new List<string>();
            Assert.AreEqual(list, uniquechars.UniqueCharacters("meme"));
        }

        [Test]
        public void TestAllUniqueChars()
        {
            var uniquechars = new UniqueCharacter();
            var list = new List<string>{ "s", "a", "l", "t" };
            Assert.AreEqual(list, uniquechars.UniqueCharacters("salt"));
        }

        [Test]
        public void TestSomeUniqueChars()
        {
            var uniquechars = new UniqueCharacter();
            var list = new List<string> { "a", "r", "e" };
            Assert.AreEqual(list, uniquechars.UniqueCharacters("address"));
            list = new List<string> { "n", "g", "r", "m" };
            Assert.AreEqual(list, uniquechars.UniqueCharacters("anagram"));
        }
    }
}
