namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoldierIsInArmyHasSoldiers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Soldiers", "Army_Id", c => c.Int());
            AddForeignKey("dbo.Soldiers", "Army_Id", "dbo.Armies", "Id");
            CreateIndex("dbo.Soldiers", "Army_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Soldiers", new[] { "Army_Id" });
            DropForeignKey("dbo.Soldiers", "Army_Id", "dbo.Armies");
            DropColumn("dbo.Soldiers", "Army_Id");
        }
    }
}
