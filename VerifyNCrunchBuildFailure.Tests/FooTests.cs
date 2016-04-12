using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VerifyNCrunchBuildFailure.Tests
{
    [TestClass()]
    public class FooTests
    {
        [TestMethod()]
        public void BarTest()
        {
            var foo = new Foo();
            const string expectation = "bar";
            Assert.AreEqual(expectation, foo.Bar());
        }
    }
}