namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostsAndAreas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CreatedUser_Id = c.String(maxLength: 128),
                        Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedUser_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.CreatedUser_Id)
                .Index(t => t.Post_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Posts", "CreatedUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "Post_Id" });
            DropIndex("dbo.Posts", new[] { "CreatedUser_Id" });
            DropTable("dbo.Posts");
        }
    }
}
