namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Post_Id", c => c.Int());
            CreateIndex("dbo.Posts", "Post_Id");
            AddForeignKey("dbo.Posts", "Post_Id", "dbo.Posts", "Id");
            DropColumn("dbo.Posts", "Post");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Post", c => c.String());
            DropForeignKey("dbo.Posts", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Posts", new[] { "Post_Id" });
            DropColumn("dbo.Posts", "Post_Id");
        }
    }
}
