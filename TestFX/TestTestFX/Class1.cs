using NUnit.Framework;
using System;

namespace TestTestFX
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestResource()
        {
            string myTESTString = TestFX.TestFXResource.GetTestFxResourceString();

            if (System.String.CompareOrdinal(myTESTString, "Hello World!") == 0)
            {
                Assert.IsFalse(true);
            }
            Assert.IsFalse(false);
        }
    }
}
