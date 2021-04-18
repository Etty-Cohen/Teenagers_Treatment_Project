namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        AdminId = c.Int(nullable: false),
                        MentorId = c.Int(nullable: false),
                        TeenagerId = c.Int(nullable: false),
                        Conclusion = c.String(),
                        AppointmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Mentors", t => t.MentorId, cascadeDelete: true)
                .Index(t => t.MentorId);
            
            AddColumn("dbo.Admins", "Area", c => c.Int(nullable: false));
            AddColumn("dbo.Admins", "IsMainAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.Admins", "Address_Area", c => c.Int(nullable: false));
            AddColumn("dbo.Admins", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentors", "AdminId", c => c.Int(nullable: false));
            AddColumn("dbo.Mentors", "Area", c => c.Int(nullable: false));
            AddColumn("dbo.Mentors", "Address_Area", c => c.Int(nullable: false));
            AddColumn("dbo.Mentors", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teenagers", "VolunteerId", c => c.Int(nullable: false));
            AddColumn("dbo.Teenagers", "MentorId", c => c.Int(nullable: false));
            AddColumn("dbo.Teenagers", "Address_Area", c => c.Int(nullable: false));
            AddColumn("dbo.Teenagers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teenagers", "Volunteer_VolunteerId", c => c.Int());
            AddColumn("dbo.Volunteers", "AdminId", c => c.Int(nullable: false));
            AddColumn("dbo.Volunteers", "Area", c => c.Int(nullable: false));
            AddColumn("dbo.Volunteers", "Address_Area", c => c.Int(nullable: false));
            AddColumn("dbo.Volunteers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Treatments", "Conclusion", c => c.String());
            AlterColumn("dbo.Treatments", "VolunteerId", c => c.Int());
            CreateIndex("dbo.Mentors", "AdminId");
            CreateIndex("dbo.Teenagers", "MentorId");
            CreateIndex("dbo.Teenagers", "Volunteer_VolunteerId");
            CreateIndex("dbo.Treatments", "VolunteerId");
            CreateIndex("dbo.Treatments", "TeenagerId");
            CreateIndex("dbo.Volunteers", "AdminId");
            AddForeignKey("dbo.Mentors", "AdminId", "dbo.Admins", "AdminId", cascadeDelete: true);
            AddForeignKey("dbo.Teenagers", "MentorId", "dbo.Mentors", "MentorId", cascadeDelete: true);
            AddForeignKey("dbo.Treatments", "VolunteerId", "dbo.Volunteers", "VolunteerId");
            AddForeignKey("dbo.Treatments", "TeenagerId", "dbo.Teenagers", "TeenagerId");
            AddForeignKey("dbo.Teenagers", "Volunteer_VolunteerId", "dbo.Volunteers", "VolunteerId");
            AddForeignKey("dbo.Volunteers", "AdminId", "dbo.Admins", "AdminId");
            DropColumn("dbo.Treatments", "MentorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Treatments", "MentorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Volunteers", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.Teenagers", "Volunteer_VolunteerId", "dbo.Volunteers");
            DropForeignKey("dbo.Treatments", "TeenagerId", "dbo.Teenagers");
            DropForeignKey("dbo.Treatments", "VolunteerId", "dbo.Volunteers");
            DropForeignKey("dbo.Teenagers", "MentorId", "dbo.Mentors");
            DropForeignKey("dbo.Appointments", "MentorId", "dbo.Mentors");
            DropForeignKey("dbo.Mentors", "AdminId", "dbo.Admins");
            DropIndex("dbo.Volunteers", new[] { "AdminId" });
            DropIndex("dbo.Treatments", new[] { "TeenagerId" });
            DropIndex("dbo.Treatments", new[] { "VolunteerId" });
            DropIndex("dbo.Teenagers", new[] { "Volunteer_VolunteerId" });
            DropIndex("dbo.Teenagers", new[] { "MentorId" });
            DropIndex("dbo.Appointments", new[] { "MentorId" });
            DropIndex("dbo.Mentors", new[] { "AdminId" });
            AlterColumn("dbo.Treatments", "VolunteerId", c => c.Int(nullable: false));
            DropColumn("dbo.Treatments", "Conclusion");
            DropColumn("dbo.Volunteers", "IsActive");
            DropColumn("dbo.Volunteers", "Address_Area");
            DropColumn("dbo.Volunteers", "Area");
            DropColumn("dbo.Volunteers", "AdminId");
            DropColumn("dbo.Teenagers", "Volunteer_VolunteerId");
            DropColumn("dbo.Teenagers", "IsActive");
            DropColumn("dbo.Teenagers", "Address_Area");
            DropColumn("dbo.Teenagers", "MentorId");
            DropColumn("dbo.Teenagers", "VolunteerId");
            DropColumn("dbo.Mentors", "IsActive");
            DropColumn("dbo.Mentors", "Address_Area");
            DropColumn("dbo.Mentors", "Area");
            DropColumn("dbo.Mentors", "AdminId");
            DropColumn("dbo.Admins", "IsActive");
            DropColumn("dbo.Admins", "Address_Area");
            DropColumn("dbo.Admins", "IsMainAdmin");
            DropColumn("dbo.Admins", "Area");
            DropTable("dbo.Appointments");
        }
    }
}
