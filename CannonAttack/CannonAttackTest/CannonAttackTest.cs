using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CannonAttack;
namespace CannonAttackTest
{
    [TestClass]
    public class CannonAttackTest
    {
        private static Cannon cannon;
        [ClassInitialize()]
        public static void CannonTestsInitialize(TestContext testContext)
        {
            cannon = Cannon.GetInstance();
        }
        [TestMethod]
        public void TestCannonIDValid()
        {
            Assert.IsNotNull(cannon.ID);
        }
        [TestMethod]
        public void TestCannonMultipleInstances()
        {
            Cannon cannon2 = Cannon.GetInstance();
            Assert.IsTrue(cannon == cannon2);
        }
        [TestMethod]
        public void TestCannonShootAngleIncorrect()
        {
            var shot = cannon.Shoot(95, 100);
            Assert.IsFalse(shot.Item1);
        }
    }
}