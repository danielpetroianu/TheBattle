using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model.Entities
{
    public class Weapon : DbBase.DbEntity<int>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Damage { get; set; }

        public bool IsBetterThan(Weapon otherWeapon)
        {
            return this.Damage >= otherWeapon.Damage;
        }
    }
}
