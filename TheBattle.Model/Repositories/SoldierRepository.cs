﻿using System.Linq;
using TheBattle.Model.Entities;
using TheBattle.Model.Repositories.Base;

namespace TheBattle.Model.Repositories
{
    public class SoldierRepository : Repository<TheBattleContext, Soldier>, ISoldierRepository
    {
        public IQueryable<Soldier> GetAllFromArmy(Army army)
        {
            if (army == null)
                return null;

            return Context.Armies.Find(army.Id).Soldiers.AsQueryable<Soldier>();
        }
    }
}
