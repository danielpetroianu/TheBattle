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
                w => w.Name,
                new Weapon(WeaponType.BareFist.ToString(),  WeaponType.BareFist,    1),
                new Weapon(WeaponType.Axe.ToString(),       WeaponType.Axe,         3),
                new Weapon(WeaponType.Sword.ToString(),     WeaponType.Sword,       2),
                new Weapon(WeaponType.Spear.ToString(),     WeaponType.Spear,       2)
            );
        }
    }
}
