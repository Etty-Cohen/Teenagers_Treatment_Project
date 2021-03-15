namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        IdNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Address_City = c.String(),
                        Address_Street = c.String(),
                        Address_BuildingNumber = c.Int(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Mentors",
                c => new
                    {
                        MentorId = c.Int(nullable: false, identity: true),
                        IdNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Address_City = c.String(),
                        Address_Street = c.String(),
                        Address_BuildingNumber = c.Int(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.MentorId);
            
            CreateTable(
                "dbo.Teenagers",
                c => new
                    {
                        TeenagerId = c.Int(nullable: false, identity: true),
                        IdNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Address_City = c.String(),
                        Address_Street = c.String(),
                        Address_BuildingNumber = c.Int(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.TeenagerId);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        TreatmentId = c.Int(nullable: false, identity: true),
                        VolunteerId = c.Int(nullable: false),
                        MentorId = c.Int(nullable: false),
                        TeenagerId = c.Int(nullable: false),
                        TreatmentMethod = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        TreatDurMin = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TreatmentId);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        VolunteerId = c.Int(nullable: false, identity: true),
                        IdNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Address_City = c.String(),
                        Address_Street = c.String(),
                        Address_BuildingNumber = c.Int(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.VolunteerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Volunteers");
            DropTable("dbo.Treatments");
            DropTable("dbo.Teenagers");
            DropTable("dbo.Mentors");
            DropTable("dbo.Admins");
        }
    }
}
