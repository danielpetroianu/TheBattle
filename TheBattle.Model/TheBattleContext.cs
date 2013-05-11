using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace TheBattle.Model
{
    class TheBattleContext : DbContext
    {
        public TheBattleContext() : base("Server=.;Database=TheBattle;Trusted_Connection=True;")
        {
        }

        DbSet<Soldier> Soldiers { get; set; }
        DbSet<Army> Armies { get; set; }
    }
}
