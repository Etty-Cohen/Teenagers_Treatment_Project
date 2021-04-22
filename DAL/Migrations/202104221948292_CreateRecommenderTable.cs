namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRecommenderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recommenders", "VolunteerRequestId", c => c.Int(nullable: false));
            CreateIndex("dbo.Recommenders", "VolunteerRequestId");
            AddForeignKey("dbo.Recommenders", "VolunteerRequestId", "dbo.VolunteerRequests", "VolunteerRequestId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recommenders", "VolunteerRequestId", "dbo.VolunteerRequests");
            DropIndex("dbo.Recommenders", new[] { "VolunteerRequestId" });
            DropColumn("dbo.Recommenders", "VolunteerRequestId");
        }
    }
}
