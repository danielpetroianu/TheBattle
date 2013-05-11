using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBattle.Model
{
    public class ArmyRepository
    {
        private readonly TheBattleContext _context;

        public ArmyRepository()
        {
            _context = new TheBattleContext();
        }

        ~ArmyRepository()
        {
            _context.Dispose();
        }

        #region Army
        public int Create(Army army)
        {
            if (army.Id == 0)
            {
                _context.Armies.Add(army);
                _context.SaveChanges();
            }

            return army.Id;
        }

        public Army Find(int armyId)
        {
            return _context.Armies.Find(armyId);
        }

        public void Remove(int armyId)
        {
            if (armyId <= 0)
                return;

            Army army = Find(armyId);

            if (army == null)
                return;

            int soldierCount = army.Soldiers == null ? 0 : army.Soldiers.Count;
            for (int i = soldierCount-1; i >= 0; i--)
            {
                _context.Soldiers.Remove(army.Soldiers[i]);
            }

            _context.Armies.Remove(army);

            _context.SaveChanges();
        }
        
        public IEnumerable<Army> GetAll()
        {
            return _context.Armies.AsEnumerable();
        }

        #endregion


        #region Soldier
        public void EnlistSoldier(Soldier aBraveSoldier)
        {
            if (aBraveSoldier == null || aBraveSoldier.Id > 0)
                return;

            _context.Soldiers.Add(aBraveSoldier);
            _context.SaveChanges();
        }

        public Soldier FindEnlistedSoldier(int soldierId)
        {
            return _context.Soldiers.Find(soldierId);
        }

        public IEnumerable<Soldier> GetEnlistedSoldiers(int armyId)
        {
            return _context.Armies.Find(armyId).Soldiers;
        }

        #endregion

        
    
    }
}