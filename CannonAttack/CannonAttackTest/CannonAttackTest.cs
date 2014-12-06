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
            Cannon cannon = new Cannon();
            Assert.IsNotNull(cannon.ID);
        } 
    }
}
