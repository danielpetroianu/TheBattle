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
    }
}
