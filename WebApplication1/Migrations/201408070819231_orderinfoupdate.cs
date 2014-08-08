namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderinfoupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CreateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "CreateUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "CreateUser_Id");
            AddForeignKey("dbo.Orders", "CreateUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CreateUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Orders", new[] { "CreateUser_Id" });
            DropColumn("dbo.Orders", "CreateUser_Id");
            DropColumn("dbo.Orders", "CreateTime");
            DropColumn("dbo.Orders", "Status");
        }
    }
}
