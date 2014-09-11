namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Posts", new[] { "Post_Id" });
            AddColumn("dbo.Posts", "Post_Id1", c => c.Int());
            CreateIndex("dbo.Posts", "Post_Id1");
            AddForeignKey("dbo.Posts", "Post_Id1", "dbo.Posts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Post_Id1", "dbo.Posts");
            DropIndex("dbo.Posts", new[] { "Post_Id1" });
            DropColumn("dbo.Posts", "Post_Id1");
            CreateIndex("dbo.Posts", "Post_Id");
            AddForeignKey("dbo.Posts", "Post_Id", "dbo.Posts", "Id");
        }
    }
}
