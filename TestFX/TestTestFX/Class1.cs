using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            TestFX.Class2.TestFailure();
            TestFX.Class3.TestFailure();

            Assert.IsFalse(false);
        }
    }
}
