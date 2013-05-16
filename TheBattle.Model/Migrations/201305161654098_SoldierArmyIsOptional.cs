namespace TheBattle.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoldierArmyIsOptional : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Soldiers", "Army_Id", "dbo.Armies");
            DropIndex("dbo.Soldiers", new[] { "Army_Id" });
            AlterColumn("dbo.Soldiers", "Army_Id", c => c.Int());
            AddForeignKey("dbo.Soldiers", "Army_Id", "dbo.Armies", "Id");
            CreateIndex("dbo.Soldiers", "Army_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Soldiers", new[] { "Army_Id" });
            DropForeignKey("dbo.Soldiers", "Army_Id", "dbo.Armies");
            AlterColumn("dbo.Soldiers", "Army_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Soldiers", "Army_Id");
            AddForeignKey("dbo.Soldiers", "Army_Id", "dbo.Armies", "Id", cascadeDelete: true);
        }
    }
}
