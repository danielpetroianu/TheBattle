using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBattle.Model;

namespace TheBattle.Test
{
    [TestClass]
    public class ArmyTest
    {
        Army army;
        Soldier soldier;
        Soldier soldier2;

        [TestInitialize]
        public void buildUp()
        {
            army = new Army(6);
            soldier = new Soldier(1);
            soldier2 = new Soldier(2);
        }

        [TestCleanup]
        public void tearDown()
        {
        }

        [TestMethod]
        public void AddTest()
        {
            army.addSoldier(soldier);
            army.addSoldier(soldier2);

            Assert.IsTrue(army.getAllSoldiers().Count == 2);
            Assert.IsTrue(army.getAllSoldiers().Contains(soldier));
            Assert.IsTrue(army.getAllSoldiers().Contains(soldier2));
            Assert.IsTrue(army.getAllSoldiers().Contains(soldier) && army.getAllSoldiers().Contains(soldier2));
        }

        [TestMethod]
        public void NullTest()
        {
            Assert.IsTrue(army.getAllSoldiers() != null);

            army.addSoldier(null);

            Assert.IsTrue(army.getAllSoldiers() != null);
            Assert.IsTrue(army.getAllSoldiers().Count == 0);

            army.addSoldier(soldier);

            Assert.IsTrue(army.getAllSoldiers().Count == 1);
            Assert.IsTrue(army.getAllSoldiers().Contains(soldier));
            Assert.IsFalse(army.getAllSoldiers().Contains(null));
        }

    }
}
