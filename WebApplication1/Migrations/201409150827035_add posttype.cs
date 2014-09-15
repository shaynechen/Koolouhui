namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addposttype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "IsTop", c => c.Int(nullable: false));
            AddColumn("dbo.Posts", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Posts", "PostType_Id", c => c.Int());
            CreateIndex("dbo.Posts", "PostType_Id");
            AddForeignKey("dbo.Posts", "PostType_Id", "dbo.PostTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "PostType_Id", "dbo.PostTypes");
            DropIndex("dbo.Posts", new[] { "PostType_Id" });
            DropColumn("dbo.Posts", "PostType_Id");
            DropColumn("dbo.Posts", "Discriminator");
            DropColumn("dbo.Posts", "IsTop");
            DropTable("dbo.PostTypes");
        }
    }
}
