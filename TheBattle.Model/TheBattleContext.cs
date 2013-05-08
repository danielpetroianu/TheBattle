using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace TheBattle.Model
{
    class TheBattleContext : DbContext
    {
        DbSet<ISoldier> Soldiers { get; set; }
        DbSet<Army> Armies { get; set; }
    }
}
