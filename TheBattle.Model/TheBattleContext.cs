using System.Data.Entity;

namespace TheBattle.Model
{
    public class TheBattleContext : DbContext
    {
        public TheBattleContext() : base("Server=ANCA-PC\\SQLEXPRESS;Database=TheBattle;Trusted_Connection=True;")
        {
        }

        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<Army> Armies { get; set; }
    }
}
