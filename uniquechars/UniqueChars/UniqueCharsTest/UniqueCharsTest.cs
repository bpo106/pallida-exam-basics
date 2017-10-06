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
            var list = new List<string>();
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("meme"));
        }

        [Test]
        public void TestAllUniqueChars()
        {
            var list = new List<string>{ "s", "a", "l", "t" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("salt"));
        }

        [Test]
        public void TestSomeUniqueChars()
        {
            var list = new List<string> { "a", "r", "e" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("address"));
            list = new List<string> { "n", "g", "r", "m" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("anagram"));
        }
    }
}
