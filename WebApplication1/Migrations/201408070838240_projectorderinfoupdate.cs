namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projectorderinfoupdate : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.Orders", newName: "OrderItems");
            //AddColumn("dbo.OrderItems", "Project_Id", c => c.Int());
           // DropColumn("dbo.Orders", "Project_Id");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Orders", "Project_Id", c => c.Int());
            //DropColumn("dbo.OrderItems", "Project_Id");
            //RenameTable(name: "dbo.OrderItems", newName: "Orders");
        }
    }
}
