using NUnit.Framework;
using PostcodeLibrary;

namespace PostcodeLibraryTests
{
    [TestFixture]
    public class PostcodeTests
    {
        private Postcode _postcode;

        [SetUp]
        public void SetUp()
        {
            _postcode = new Postcode();
        }

        [Test]
        public void Postcode_Is_Created()
        {
            Assert.IsNotNull(_postcode);
        }

        [TestCase("TKCA 1ZZ")]
        [TestCase("ZZ99 3CZ")]
        [TestCase("TW8 9GS")]
        [TestCase("S6 1SW")]
        public void Valid_Postcode_Under_Test_Passes(string postcode)
        {
            bool result = _postcode.Test(postcode);
            Assert.True(result);
        }

        [TestCase("")]
        [TestCase("WIBBLE")]
        [TestCase("A B C")]
        [TestCase(null)]
        public void Non_Valid_Postcode_Under_Test_Fails(string postcode)
        {
            bool result = _postcode.Test(postcode);
            Assert.False(result);
        }
    }
}
