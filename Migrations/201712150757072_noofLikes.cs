namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noofLikes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "NumberOfLikes", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "NumberOfLikes");
        }
    }
}
