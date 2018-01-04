namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restore3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "email");
        }
    }
}
