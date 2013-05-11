using TheBattle.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Rhino.Mocks;

namespace TheBattle.Test
{
    [TestClass()]
    public class ArmyTest
    {
        /// <summary>
        ///A test for StartWarWith
        ///</summary>
        [TestMethod()]
        public void StartWarWithTest()
        {
            var attacker = new Army();
            attacker.Soldiers.AddRange(new List<Soldier>() { 
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>()
            });


            var deffender = new Army();
            deffender.Soldiers.AddRange(new List<Soldier>() { 
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>(),
                MockRepository.GenerateStub<Soldier>()
            });


            Assert.IsTrue(attacker.StartWarWith(deffender));
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
