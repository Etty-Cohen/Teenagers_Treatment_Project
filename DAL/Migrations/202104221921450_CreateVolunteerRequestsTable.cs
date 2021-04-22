namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateVolunteerRequestsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VolunteerRequests",
                c => new
                    {
                        VolunteerRequestId = c.Int(nullable: false, identity: true),
                        IdNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Address_City = c.String(),
                        Address_Area = c.Int(nullable: false),
                        Address_Street = c.String(),
                        Address_BuildingNumber = c.Int(nullable: false),
                        IsConfirmed = c.Boolean(nullable: false),
                        Description = c.String(),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VolunteerRequestId)
                .ForeignKey("dbo.Admins", t => t.AdminId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Recommenders",
                c => new
                    {
                        RecommenderId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Relationship = c.String(),
                    })
                .PrimaryKey(t => t.RecommenderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VolunteerRequests", "AdminId", "dbo.Admins");
            DropIndex("dbo.VolunteerRequests", new[] { "AdminId" });
            DropTable("dbo.Recommenders");
            DropTable("dbo.VolunteerRequests");
        }
    }
}
