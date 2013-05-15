namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoldierColumnRename_IsCapitan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Soldiers", "IsCaptain", c => c.Boolean());
            DropColumn("dbo.Soldiers", "Captain");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Soldiers", "Captain", c => c.Boolean());
            DropColumn("dbo.Soldiers", "IsCaptain");
        }
    }
}
