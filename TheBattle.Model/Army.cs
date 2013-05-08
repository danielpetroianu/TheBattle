using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model
{
    class Army
    {
        [Key]
        public int Id { get; set; }

        public virtual List<Soldier> Soldiers { get; set; }
    }
}
