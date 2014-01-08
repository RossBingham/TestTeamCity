using NUnit.Framework;

namespace TestTestFX
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestResource()
        {
            TestFX.TestFXResource.GetTestFxResourceString();

            Assert.IsFalse(false);
        }
    }
}
