using TheBattle.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TheBattle.Model;
using System.Linq;
using TheBattle.Model.Entities;
using System.Collections.Generic;

namespace TheBattle.Test
{
    [TestClass()]
    public class SoldierRepositoryTest
    {
        private ArmyRepository _armyRepo;
        private SoldierRepository _soldierRepo;

        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void TestInitialize()
        {
            _armyRepo = new ArmyRepository();
            _soldierRepo = new SoldierRepository();
        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void TestCleanup()
        {
            //remove all armys from the db
            _armyRepo.GetAll().ToList().ForEach(army => _armyRepo.Delete(army));
            _armyRepo.Save();
        }






        [TestMethod()]
        public void GetAllFromArmyTest()
        {
            int numberOfSoldiers = 4;
            string soldierPrefix = "Brave Soldier #";
            var army = new Army();
            var newSoldiers = new List<Soldier>();
            for (int i = 0; i < numberOfSoldiers; i++)
            {
                newSoldiers.Add(new Soldier(soldierPrefix + i));
            }

            army.Soldiers.AddRange(newSoldiers);

            _armyRepo.Add(army).Save();

            Assert.AreEqual(numberOfSoldiers, _soldierRepo.GetAllFromArmy(army).Count());
            Assert.AreEqual(soldierPrefix + "0", _soldierRepo.GetAllFromArmy(army).First().Name);
        }


    }
}
