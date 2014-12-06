using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CannonAttack;

namespace CannonAttackTest
{
    [TestClass]
    public class CannonAttackTest
    {
        [TestMethod]
        public void TestCannonIDValid()
        {
            Cannon cannon = Cannon.GetInstance();
            Assert.IsNotNull(cannon.ID);
        }
        [TestMethod]
        public void TestCannonMultipleInstances()
        {
            Cannon cannon = Cannon.GetInstance();
            Cannon cannon2 = Cannon.GetInstance();
            Assert.IsTrue(cannon == cannon2);
        }
    }
}
