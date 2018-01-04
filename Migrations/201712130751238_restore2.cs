namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restore2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Post", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Post", c => c.String());
        }
    }
}
