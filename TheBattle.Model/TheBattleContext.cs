using System.Data.Entity;
using TheBattle.Model.Entities;

namespace TheBattle.Model
{
    public class TheBattleContext : DbContext
    {
        public TheBattleContext() : base("Server=.\\SQLEXPRESS;Database=TheBattle;Trusted_Connection=True;")
        {
        }

        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<Army> Armies { get; set; }
    }
}
