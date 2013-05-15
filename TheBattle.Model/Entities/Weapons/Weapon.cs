using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBattle.Model.Entities.Weapon
{
    public abstract class Weapon
    {
        public abstract int GetDamage();

        public bool IsBetterThan(Weapon otherWeapon)
        {
            return this.GetDamage() >= otherWeapon.GetDamage();
        }
    }
}
