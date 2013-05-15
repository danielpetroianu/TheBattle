using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheBattle.Model.Entities;
using TheBattle.Model.Repositories.Base;

namespace TheBattle.Model.Repositories
{
    public class WeaponRepository : Repository<TheBattleContext, Weapon>, IWeaponRepository 
    {
        public override IRepository<Weapon> Add(Weapon entity)
        {
            throw new InvalidOperationException("The Weapon Model doesn't allow adding weapons");
        }

        public override IRepository<Weapon> Add(params Weapon[] items)
        {
            throw new InvalidOperationException("The Weapon Model doesn't allow adding weapons");
        }

        public override IRepository<Weapon> Add(IEnumerable<Weapon> items)
        {
            throw new InvalidOperationException("The Weapon Model doesn't allow adding weapons");
        }

        public override IRepository<Weapon> Delete(Weapon entity)
        {
            throw new InvalidOperationException("The Weapon Model doesn't allow deleting weapons");
        }

        public override IRepository<Weapon> Update(Weapon entity)
        {
            throw new InvalidOperationException("The Weapon Model doesn't allow updating weapons");
        }

        public override void Save()
        {
            throw new InvalidOperationException("The Weapon Model doesn't allow saving to database");
        }
    }
}
