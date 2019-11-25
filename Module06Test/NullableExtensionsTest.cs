using System;
using NUnit.Framework;
using Module06;

namespace Module06Test
{
    [TestFixture]
    class NullableExtensionsTest
    {
        [Test]
        public void IsNull_StringName_FalseReturned()
        {
            string name = "Kathy";
            bool result = name.IsNull();
            Assert.AreEqual(false, result);
        }
        [Test]
        public void IsNull_StringNull_TrueReturned()
        {
            string name = null;
            bool result = name.IsNull();
            Assert.AreEqual(true, result);
        }
        [Test]
        public void IsNull_Int24_FalseReturned()
        {
            int? i = 24;
            bool result = i.IsNull();
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsNull_IntNull_TrueReturned()
        {
            int? i = null;
            bool result = i.IsNull();
            Assert.AreEqual(true, result);
        }
    }
}
