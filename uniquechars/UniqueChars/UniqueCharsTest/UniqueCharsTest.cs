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
            list = new List<string>{ "a" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("a"));
        }

        [Test]
        public void TestSomeUniqueChars()
        {
            var list = new List<string> { "a", "r", "e" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("address"));
            list = new List<string> { "n", "g", "r", "m" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("anagram"));
            list = new List<string> { "a" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("bba"));
        }

        [Test]
        public void TestUpperLowerChars()
        {
            var list = new List<string> { "l", "m" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("AlMa"));
        }

        [Test]
        public void TestMoreThanOneWord()
        {
            var list = new List<string> { "v", "n", "p", "u", "s", "t", "w", "o" };
            Assert.AreEqual(list, UniqueCharacter.UniqueCharacters("eleven plus two"));
        }
    }
}
