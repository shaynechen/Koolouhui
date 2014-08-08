namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSupportamountWithReturnContent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupportAmounts", "ReturnContent", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SupportAmounts", "ReturnContent");
        }
    }
}
