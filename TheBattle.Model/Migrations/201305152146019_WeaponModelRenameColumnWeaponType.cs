namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeaponModelRenameColumnWeaponType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Weapons", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Weapons", "WeaponType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapons", "WeaponType", c => c.Int(nullable: false));
            DropColumn("dbo.Weapons", "Type");
        }
    }
}
