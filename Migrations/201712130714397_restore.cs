namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restore : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Posts");
        }
        
        public override void Down()
        {
        }
    }
}
