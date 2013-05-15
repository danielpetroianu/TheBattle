namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class soldierCaptain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Soldiers", "Captain", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Soldiers", "Captain");
        }
    }
}
