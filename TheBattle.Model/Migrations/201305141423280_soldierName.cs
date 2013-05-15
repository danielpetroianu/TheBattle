namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class soldierName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Soldiers", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Soldiers", "Name");
        }
    }
}
