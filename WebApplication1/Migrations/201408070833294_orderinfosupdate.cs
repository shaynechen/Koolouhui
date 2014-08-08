namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderinfosupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BelongTo_Id = c.Int(),
                        SupportProject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.BelongTo_Id)
                .ForeignKey("dbo.SupportAmounts", t => t.SupportProject_Id)
                .Index(t => t.BelongTo_Id)
                .Index(t => t.SupportProject_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "SupportProject_Id", "dbo.SupportAmounts");
            DropForeignKey("dbo.OrderItems", "BelongTo_Id", "dbo.Orders");
            DropIndex("dbo.OrderItems", new[] { "SupportProject_Id" });
            DropIndex("dbo.OrderItems", new[] { "BelongTo_Id" });
            DropTable("dbo.OrderItems");
        }
    }
}
