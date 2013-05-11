using TheBattle.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace TheBattle.Test
{
    /// <summary>
    ///This is a test class for ArmyRepositoryTest and is intended
    ///to contain all ArmyRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ArmyRepositoryTest
    {
        private ArmyRepository _armyRepo;

        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void TestInitialize()
        {
            _armyRepo = new ArmyRepository();
        }
        
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {


            //remove all armys from the db
            _armyRepo.GetAll().ToList().ForEach(a => _armyRepo.Remove(a.Id));
        }
        



        [TestMethod()]
        public void CreateArmy()
        {
            int armyId = _armyRepo.Create(new Army());

            Assert.AreEqual(1, _armyRepo.GetAll().Count());
            Assert.IsNotNull(_armyRepo.Find(armyId));
        }

        [TestMethod()]
        public void EnlistSoldierTest_withNoSoldier()
        {
            int armyId = _armyRepo.Create(new Army());

            _armyRepo.EnlistSoldier(null);

            Assert.AreEqual(0,_armyRepo.GetEnlistedSoldiers(armyId).Count());
        }

        [TestMethod()]
        public void EnlistSoldierTest_withOneSoldier()
        {
            int armyId = _armyRepo.Create(new Army());

            Soldier soldier = new Soldier() { Army = _armyRepo.Find(armyId)};
            _armyRepo.EnlistSoldier(soldier);

            Assert.AreEqual(1, _armyRepo.GetEnlistedSoldiers(armyId).Count());
        }

        [TestMethod()]
        public void EnlistSoldierTest_withTheSameSoldier()
        {
            int armyId = _armyRepo.Create(new Army());

            Soldier soldier = new Soldier() { Army = _armyRepo.Find(armyId)};
            _armyRepo.EnlistSoldier(soldier);
            _armyRepo.EnlistSoldier(soldier);

            Assert.AreEqual(1, _armyRepo.GetEnlistedSoldiers(armyId).Count());
        }

        /// <summary>
        ///A test for GetEnlistedSoldiers
        ///</summary>
        [TestMethod()]
        public void GetEnlistedSoldiersTest()
        {
            int armyId = _armyRepo.Create(new Army());

            Assert.AreEqual(0, _armyRepo.GetEnlistedSoldiers(armyId).Count());

            _armyRepo.EnlistSoldier(new Soldier() { Army = _armyRepo.Find(armyId) });
            _armyRepo.EnlistSoldier(new Soldier() { Army = _armyRepo.Find(armyId) });
            _armyRepo.EnlistSoldier(new Soldier() { Army = _armyRepo.Find(armyId) });
            _armyRepo.EnlistSoldier(new Soldier() { Army = _armyRepo.Find(armyId) });

            Assert.AreEqual(4, _armyRepo.GetEnlistedSoldiers(armyId).Count());
        }


        [TestMethod()]
        public void RemoveArmy_withNoSoldiers()
        {
            int armyId = _armyRepo.Create(new Army());
            _armyRepo.Remove(armyId);

            Assert.IsNull(_armyRepo.Find(armyId));
        }

        [TestMethod()]
        public void RemoveArmy_withSoldiers()
        {
            int armyId = _armyRepo.Create(new Army());

            List<Soldier> soldiers = new List<Soldier>
            {
                new Soldier() { Army = _armyRepo.Find(armyId) },
                new Soldier() { Army = _armyRepo.Find(armyId) },
                new Soldier() { Army = _armyRepo.Find(armyId) },
                new Soldier() { Army = _armyRepo.Find(armyId) }
            };

            foreach (var soldier in soldiers)
            {
                _armyRepo.EnlistSoldier(soldier);
            }

            _armyRepo.Remove(armyId);

            Assert.IsNull(_armyRepo.Find(armyId));
            foreach (var soldier in soldiers)
            {
                Assert.IsNull(_armyRepo.FindEnlistedSoldier(soldier.Id));
            }

        }


    }
}
