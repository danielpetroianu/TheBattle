namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArmyHasName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Armies", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Armies", "Name");
        }
    }
}
