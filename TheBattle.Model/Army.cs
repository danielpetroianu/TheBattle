using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model
{
    public class Army : DbBase.DbEntity<int>
    {
        public virtual List<Soldier> Soldiers { get; set; }
    }
}
