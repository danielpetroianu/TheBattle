namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeaponModelRenameColumnType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Weapons", "WeaponType", c => c.Int(nullable: false));
            DropColumn("dbo.Weapons", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Weapons", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Weapons", "WeaponType");
        }
    }
}
