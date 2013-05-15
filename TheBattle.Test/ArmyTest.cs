using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using TheBattle.Model;
using TheBattle.Model.Entities;

namespace TheBattle.Test
{
    [TestClass()]
    public class ArmyTest
    {
        //[TestMethod()]
        //public void StartWarWith()
        //{
        //    Soldier soldier1_army1 = MockRepository.GenerateStub<Soldier>();
        //    Soldier soldier2_army1 = MockRepository.GenerateStub<Soldier>();
        //    Soldier soldier3_army1 = MockRepository.GenerateStub<Soldier>();

        //    Soldier soldier1_army2 = MockRepository.GenerateStub<Soldier>();
        //    Soldier soldier2_army2 = MockRepository.GenerateStub<Soldier>();
        //    Soldier soldier3_army2 = MockRepository.GenerateStub<Soldier>();
        //    Soldier soldier4_army2 = MockRepository.GenerateStub<Soldier>();


        //    soldier1_army1.Stub(x => x.Fight(soldier1_army2)).Return(Soldier.FightOutcome.Win);
        //    soldier1_army1.Stub(x => x.Fight(soldier2_army2)).Return(Soldier.FightOutcome.Win);
        //    soldier1_army1.Stub(x => x.Fight(soldier3_army2)).Return(Soldier.FightOutcome.Win);
        //    soldier1_army1.Stub(x => x.Fight(soldier4_army2)).Return(Soldier.FightOutcome.Win);

        //    var attacker = new Army();
        //    attacker.Soldiers.AddRange(new List<Soldier>() { 
        //        soldier1_army1,
        //        soldier2_army1,
        //        soldier3_army1
        //    });

        //    var deffender = new Army();
        //    deffender.Soldiers.AddRange(new List<Soldier>() { 
        //        soldier1_army2,
        //        soldier2_army2,
        //        soldier3_army2,
        //        soldier4_army2
        //    });

            
        //    Assert.AreEqual(true, attacker.StartWarWith(deffender));
        //}

        [TestMethod()]
        public void SoldierFightTest_NullSoldiers2()
        {
            Soldier soldier = MockRepository.GenerateStub<Soldier>();
            Soldier soldier2 = null;

            Assert.AreEqual(Soldier.FightOutcome.InvalidResult, soldier.Fight(soldier2));
        }

        [TestMethod()]
        public void FrontManTest_ArmyWithNoSoldiers()
        {
            var attacker = new Army();

            Assert.IsNull(attacker.FrontMan);
        }

        [TestMethod()]
        public void FrontManTest_ArmyWithSomeSolders()
        {
            var army = new Army();
            army.Soldiers.AddRange(new List<Soldier>() { 
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>()
            });

            for (int i = army.Soldiers.Count - 1; i >= 0; i--)
            {
                Assert.AreEqual(army.Soldiers[0], army.FrontMan);
                army.Soldiers.RemoveAt(0);
            }

        }
    }
}
