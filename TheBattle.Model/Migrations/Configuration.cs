namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TheBattle.Model.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TheBattle.Model.TheBattleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheBattle.Model.TheBattleContext context)
        {
            context.Weapons.AddOrUpdate(
                new Weapon(WeaponType.BareFist.ToString(), WeaponType.BareFist, 1)
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
