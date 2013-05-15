using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBattle.Model.Entities;
using TheBattle.Model.Repositories;

namespace TheBattle.Test
{
    [TestClass()]
    public class ArmyRepositoryTest
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
        public void CreateArmy()
        {
            var newArmy = new Army();

            //method beeng tested
            _armyRepo.Add(newArmy);
            _armyRepo.Save();

            Assert.AreNotEqual(0, newArmy.Id);
            Assert.AreEqual(1, _armyRepo.GetAll().Count());
            Assert.AreEqual(1, _armyRepo.FindBy(a => a.Id == newArmy.Id).Count());
        }

        [TestMethod]
        public void EditArmy_UpdateSoldiers()
        {
            var newArmy = new Army();

            _armyRepo.Add(newArmy);
            _armyRepo.Save();

            Assert.AreEqual(1, _armyRepo.GetAll().Count());
            Assert.AreEqual(0, newArmy.Soldiers.Count);

            newArmy.Soldiers.Add(new Soldier("Brave Soldier #1"));

            //method beeng tested
            _armyRepo.Update(newArmy);
            _armyRepo.Save();

            Assert.AreEqual(1, newArmy.Soldiers.Count);
        }

        [TestMethod()]
        public void RemoveArmy_withNoSoldiers()
        {
            var newArmy = new Army();

            _armyRepo.Add(newArmy);
            _armyRepo.Save();

            Assert.AreNotEqual(0, newArmy.Id);
            Assert.AreEqual(1, _armyRepo.GetAll().Count());
            Assert.IsNotNull(_armyRepo.FindBy(a => a.Id == newArmy.Id));

            int armyId = newArmy.Id;

            //method beeng tested
            _armyRepo.Delete(newArmy);
            _armyRepo.Save();

            Assert.AreEqual(0, _armyRepo.GetAll().Count());
            Assert.IsNull(_armyRepo.FindBy(a => a.Id == armyId).FirstOrDefault());
        }

        [TestMethod()]
        public void RemoveArmy_withSoldiers()
        {
            int numberOfSoldiers = 4;
            var newArmy = new Army();

            var newSoldiers = new List<Soldier>();
            for (int i = 0; i < numberOfSoldiers; i++)
            {
                newSoldiers.Add(new Soldier("Brave Soldier #" + i));
            }

            newArmy.Soldiers.AddRange(newSoldiers);

            _armyRepo.Add(newArmy);
            _armyRepo.Save();

            var armyId = newArmy.Id;
            var soldierId = new int[numberOfSoldiers];
            for (int i = 0; i < numberOfSoldiers; i++)
            {
                soldierId[i] = newSoldiers[i].Id;
            }

            Assert.AreNotEqual(0, newArmy.Id);
            Assert.AreEqual(1, _armyRepo.GetAll().Count());
            Assert.AreEqual(1, _armyRepo.FindBy(a => a.Id == armyId).Count());
            Assert.AreEqual(numberOfSoldiers, _armyRepo.FindBy(a => a.Id == armyId).First().Soldiers.Count);

            //method beeng tested
            _armyRepo.Delete(newArmy);
            _armyRepo.Save();

            Assert.AreEqual(0, _armyRepo.FindBy(a => a.Id == armyId).Count());
            for (int i = 0; i < numberOfSoldiers; i++)
            {
                int sid = soldierId[i];
                Assert.AreEqual(0, _soldierRepo.FindBy(s => s.Id == sid).Count());
            }

        }


        [TestMethod()]
        public void EnlistSoldierTest_withNoSoldier()
        {
            var newArmy = new Army();
            newArmy.Soldiers = null;

            _armyRepo.Add(newArmy).Save();

            Assert.IsNull(_armyRepo.FindBy(a => a.Id == newArmy.Id).First().Soldiers);
        }

        [TestMethod()]
        public void EnlistSoldierTest_withOneSoldier()
        {
            var newArmy = new Army();
            newArmy.Soldiers.Add(new Soldier("Soldier1"));

            _armyRepo.Add(newArmy).Save();

            Assert.AreEqual(1, _armyRepo.FindBy(a => a.Id == newArmy.Id).First().Soldiers.Count);
        }

        [TestMethod()]
        public void EnlistSoldierTest_withTheSameSoldier()
        {
            Soldier soldier = new Soldier("Soldier1");

            var newArmy = new Army();
            newArmy.Soldiers.Add(soldier);

            _armyRepo.Add(newArmy).Save();

            Assert.AreEqual(1, _armyRepo.FindBy(a => a.Id == newArmy.Id).First().Soldiers.Count);
        }


        [TestMethod]
        public void EnlistSoldierInArmyAllreadyEnlisted_incrementalRepoSave()
        {
            var spy = new Soldier("James Bond");

            var army1 = new Army();
            army1.Soldiers.Add(spy);
            army1.Soldiers.Add(new Soldier("Brave Soldier"));

            _armyRepo.Add(army1).Save();

            var army2 = new Army();
            army2.Soldiers.Add(spy);
            army2.Soldiers.Add(new Soldier("Brave Soldier"));
            army2.Soldiers.Add(new Soldier("Brave Soldier"));

            _armyRepo.Add(army2).Save();

            Assert.AreEqual(army2.Id, spy.Army.Id);
        }

        [TestMethod]
        public void EnlistSoldierInArmyAllreadyEnlisted_oneRepoSave()
        {
            var spy = new Soldier("James Bond");

            var army1 = new Army();
            army1.Soldiers.Add(spy);
            army1.Soldiers.Add(new Soldier("Brave Soldier"));

            var army2 = new Army();
            army2.Soldiers.Add(spy);
            army2.Soldiers.Add(new Soldier("Brave Soldier"));
            army2.Soldiers.Add(new Soldier("Brave Soldier"));

            _armyRepo.Add(army1, army2).Save();

            Assert.AreEqual(army2.Id, spy.Army.Id);
        }
    }
}
