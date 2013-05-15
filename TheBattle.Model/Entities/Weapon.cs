using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBattle.Model.Entities
{
    public enum WeaponType
    {
        BareFist
    }

    public class Weapon : DbBase.DbEntity<int>
    {
        public Weapon() : this(WeaponType.BareFist) {}
        public Weapon(WeaponType type)
        {
            Type = type;
        }
        internal Weapon(string name, WeaponType type, int damage ) : this(type)
        {
            Name = name;
            Damage = damage;
        }

        [Required]
        [StringLength(50)]
        public string Name { get; private set; }

        public int Damage { get; private set; }

        [Column("Type")]
        public int TypeAsInt { get; private set; }

        public WeaponType Type 
        {
            get { return (WeaponType)TypeAsInt; }
            private set { TypeAsInt = (int)value; }
        }
        
        public bool IsBetterThan(Weapon otherWeapon)
        {
            return this.Damage >= otherWeapon.Damage;
        }
    }
}
