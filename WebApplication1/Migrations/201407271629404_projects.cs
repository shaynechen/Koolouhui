namespace Koo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projects : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Products", "BelongTo_Id", "dbo.Projects");
            //DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            //DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            //DropIndex("dbo.Products", new[] { "BelongTo_Id" });
            //DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            //DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            UserName = c.String(),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            Discriminator = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //AddColumn("dbo.AspNetUserClaims", "User_Id", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.AspNetRoles", "Name", c => c.String(nullable: false));
            //AlterColumn("dbo.AspNetUserRoles", "UserId", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.AspNetUserRoles", "RoleId", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.AspNetUserLogins", "UserId", c => c.String(nullable: false, maxLength: 128));
            //DropPrimaryKey("dbo.AspNetUserLogins");
            //AddPrimaryKey("dbo.AspNetUserLogins", new[] { "UserId", "LoginProvider", "ProviderKey" });
            //CreateIndex("dbo.AspNetUserLogins", "UserId");
            //CreateIndex("dbo.AspNetUserRoles", "RoleId");
            //CreateIndex("dbo.AspNetUserRoles", "UserId");
            //CreateIndex("dbo.AspNetUserClaims", "User_Id");
            //AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            //DropColumn("dbo.AspNetUserClaims", "UserId");
            //DropTable("dbo.Orders");
            //DropTable("dbo.Products");
            //DropTable("dbo.AspNetUsers");
        }
        
        public override void Down()
        {
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            MobileNumber = c.String(),
            //            Email = c.String(maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Products",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Description = c.String(),
            //            BelongTo_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Orders",
            //    c => new
            //        {
            //            InterlId = c.Int(nullable: false, identity: true),
            //            DisplayId = c.String(),
            //            CreateTime = c.DateTime(nullable: false),
            //            Unit = c.Int(nullable: false),
            //            UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.InterlId);
            
            //AddColumn("dbo.AspNetUserClaims", "UserId", c => c.String(nullable: false, maxLength: 128));
            //DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            //DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            //DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            //DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            //DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            //DropPrimaryKey("dbo.AspNetUserLogins");
            //AddPrimaryKey("dbo.AspNetUserLogins", new[] { "LoginProvider", "ProviderKey", "UserId" });
            //AlterColumn("dbo.AspNetUserLogins", "UserId", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.AspNetUserRoles", "RoleId", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.AspNetUserRoles", "UserId", c => c.String(nullable: false, maxLength: 128));
            //AlterColumn("dbo.AspNetRoles", "Name", c => c.String(nullable: false, maxLength: 256));
            //DropColumn("dbo.AspNetUserClaims", "User_Id");
            //DropTable("dbo.AspNetUsers");
            //CreateIndex("dbo.AspNetUserRoles", "UserId");
            //CreateIndex("dbo.AspNetUserLogins", "UserId");
            //CreateIndex("dbo.AspNetUserClaims", "UserId");
            //CreateIndex("dbo.AspNetUserRoles", "RoleId");
            //CreateIndex("dbo.Products", "BelongTo_Id");
            //AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.Products", "BelongTo_Id", "dbo.Projects", "Id");
        }
    }
}
