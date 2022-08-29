using NUnit.Framework;
using TeamCityCITest.Api;

namespace TeamCityCITest.UnitTest
{
    [TestFixture]
    public class GenericTest
    {
        readonly IValues valuesService = new Values();

        [Test]
        public void SuccessTest()
        {
            Assert.AreEqual(valuesService.Get(), "Stefano");
        }

        [Test]
        public void FailTest()
        {
            Assert.AreEqual(valuesService.Get(), "Stefano12");
        }
    }
}