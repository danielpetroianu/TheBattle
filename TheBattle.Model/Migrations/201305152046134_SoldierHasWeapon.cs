namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoldierHasWeapon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Soldiers", "Weapon_Id", c => c.Int(nullable: false));
            AddForeignKey("dbo.Soldiers", "Weapon_Id", "dbo.Weapons", "Id", cascadeDelete: true);
            CreateIndex("dbo.Soldiers", "Weapon_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Soldiers", new[] { "Weapon_Id" });
            DropForeignKey("dbo.Soldiers", "Weapon_Id", "dbo.Weapons");
            DropColumn("dbo.Soldiers", "Weapon_Id");
        }
    }
}
