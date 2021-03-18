using NUnit.Framework;

namespace MetodyNumeryczne
{
    [TestFixture]
    class LagrangeTest
    {
        
        public void LagrangeShould()
        {
            string[] lines = { "1,2,3", "4,5,6" };
            var lagrange = new Lagrange();
            Assert.IsTrue(lagrange.PrepareData(lines));
        }

        
        [TestCase((object)new[] { "1,2,3", "1,2,3,4" })]
        [TestCase((object)new[] { "1,2", "1,2" })]
        public void LagrangeShouldNot(string[] lines)
        {
            var lagrange = new Lagrange();
            Assert.IsFalse(lagrange.PrepareData(lines));
        }
    }
}
