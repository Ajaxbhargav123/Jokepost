namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class titlespost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "title", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Posts", "Post", c => c.String(nullable: false, maxLength: 60));
            DropColumn("dbo.Posts", "NumberOfLikes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "NumberOfLikes", c => c.Double(nullable: false));
            AlterColumn("dbo.Posts", "Post", c => c.String(nullable: false));
            DropColumn("dbo.Posts", "title");
        }
    }
}
