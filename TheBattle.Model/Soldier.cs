﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model
{
    public class Soldier : DbBase.DbEntity<int>
    {
        public virtual Army Army { get; set; }


        [Required]
        [StringLength(50)]
        public string Name
        {
            get;
            set;

        }

        public bool Captain
        {
            get;
            set;
        }


        public bool Fight(Soldier otherSoldier)
        {
            throw new NotImplementedException("To be implemented in other story");
        }
    }
}
