using NUnit.Framework;
using baselibrary;

namespace baselibrary.tests
{
    [TestFixture(Category = "Unit")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var c1 = new Class1();
            var actual = c1.ReturnsTrue();
            Assert.That(actual, Is.True);
        }
    }
}