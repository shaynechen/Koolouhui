namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projecInfoUpdateSupportedOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            AddColumn("dbo.Projects", "TargetAmount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Orders", new[] { "Project_Id" });
            DropColumn("dbo.Projects", "TargetAmount");
            DropTable("dbo.Orders");
        }
    }
}
