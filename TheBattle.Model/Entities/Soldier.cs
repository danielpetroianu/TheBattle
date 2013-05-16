﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model.Entities
{
    public class Soldier : DbBase.DbEntity<int>
    {
        public enum FightOutcome
        {
            Win,
            Loss,
            InvalidResult
        };

        public Soldier() : this(string.Empty) { }
        public Soldier(string name) { Name = name; Weapon = new Weapon(); }

        [Required]
        public virtual Army Army 
        { 
            get; 
            set; 
        }

        [Required]
        public virtual Weapon Weapon
        {
            get;
            set;
        }

        [Required]
        [StringLength(50)]
        public string Name
        {
            get;
            private set;
        }

        public bool? IsCaptain
        {
            get;
            set;
        }

        public FightOutcome Fight(Soldier otherSoldier)
        {
            if (otherSoldier == null || otherSoldier == this)
            {
                return FightOutcome.InvalidResult;
            }

            return this.Weapon.IsBetterThan(otherSoldier.Weapon)
                ? FightOutcome.Win
                : FightOutcome.Loss;

        }
    }
}
