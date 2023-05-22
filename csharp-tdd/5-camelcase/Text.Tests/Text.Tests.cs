using NUnit.Framework;
using Text;

namespace Text.Tests
{

    public class Tests
    {
        [Test]
        public void Test_EmptyString()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void Test_SingleWord()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void Test_TwoWords()
        {
            Assert.AreEqual(2, Str.CamelCase("helloWorld"));
        }

        [Test]
        public void Test_MultipleWords()
        {
            Assert.AreEqual(4, Str.CamelCase("helloWorldCamelCase"));
        }
    }
}