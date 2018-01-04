namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class titlespost1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "title", c => c.String(nullable: false, maxLength: 22));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "title", c => c.String(nullable: false, maxLength: 12));
        }
    }
}
