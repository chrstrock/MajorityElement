using NUnit.Framework;

namespace MajorityElement
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OneEqualsOneTest()
        {
            int[] nums = { 1 };
            NumArray numArray = new NumArray();
            Assert.AreEqual(1, numArray.MajorityElement(nums));
        }

        [Test]
        public void ThreeTwoThreeReturnsThreeTest()
        {
            int[] nums = { 3, 2, 3 };
            NumArray numArray = new NumArray();
            Assert.AreEqual(3, numArray.MajorityElement(nums));
        }
    }
}