namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeaponHasType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Weapons", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Weapons", "Type");
        }
    }
}
