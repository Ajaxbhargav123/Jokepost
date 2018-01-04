namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostMigration2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Posts", new[] { "Post_Id" });
            AddColumn("dbo.Posts", "Post", c => c.String());
            DropColumn("dbo.Posts", "Post_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Post_Id", c => c.Int());
            DropColumn("dbo.Posts", "Post");
            CreateIndex("dbo.Posts", "Post_Id");
            AddForeignKey("dbo.Posts", "Post_Id", "dbo.Posts", "Id");
        }
    }
}
