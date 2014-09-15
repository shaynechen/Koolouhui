namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class replyid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ReplyPost_Id", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "ReplyPost_Id");
        }
    }
}
