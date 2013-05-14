using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBattle.Model
{
    public abstract class Weapon
    {
        public abstract int GetDamage();

        public  isBetterThan(Weapon otherWeapon)
        {
            return this.GetDamage() >= otherWeapon.GetDamage();
        }
    }
}
