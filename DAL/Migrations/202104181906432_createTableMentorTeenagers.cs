namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableMentorTeenagers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teenagers", "MentorId", "dbo.Mentors");
            DropForeignKey("dbo.Teenagers", "Volunteer_VolunteerId", "dbo.Volunteers");
            DropIndex("dbo.Teenagers", new[] { "MentorId" });
            DropIndex("dbo.Teenagers", new[] { "Volunteer_VolunteerId" });
            CreateTable(
                "dbo.MentorTeenagers",
                c => new
                    {
                        Mentor_MentorId = c.Int(nullable: false),
                        Teenager_TeenagerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Mentor_MentorId, t.Teenager_TeenagerId })
                .ForeignKey("dbo.Mentors", t => t.Mentor_MentorId, cascadeDelete: true)
                .ForeignKey("dbo.Teenagers", t => t.Teenager_TeenagerId, cascadeDelete: true)
                .Index(t => t.Mentor_MentorId)
                .Index(t => t.Teenager_TeenagerId);
            
            CreateIndex("dbo.Appointments", "TeenagerId");
            AddForeignKey("dbo.Appointments", "TeenagerId", "dbo.Teenagers", "TeenagerId", cascadeDelete: true);
            DropColumn("dbo.Teenagers", "VolunteerId");
            DropColumn("dbo.Teenagers", "MentorId");
            DropColumn("dbo.Teenagers", "Volunteer_VolunteerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teenagers", "Volunteer_VolunteerId", c => c.Int());
            AddColumn("dbo.Teenagers", "MentorId", c => c.Int(nullable: false));
            AddColumn("dbo.Teenagers", "VolunteerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.MentorTeenagers", "Teenager_TeenagerId", "dbo.Teenagers");
            DropForeignKey("dbo.MentorTeenagers", "Mentor_MentorId", "dbo.Mentors");
            DropForeignKey("dbo.Appointments", "TeenagerId", "dbo.Teenagers");
            DropIndex("dbo.MentorTeenagers", new[] { "Teenager_TeenagerId" });
            DropIndex("dbo.MentorTeenagers", new[] { "Mentor_MentorId" });
            DropIndex("dbo.Appointments", new[] { "TeenagerId" });
            DropTable("dbo.MentorTeenagers");
            CreateIndex("dbo.Teenagers", "Volunteer_VolunteerId");
            CreateIndex("dbo.Teenagers", "MentorId");
            AddForeignKey("dbo.Teenagers", "Volunteer_VolunteerId", "dbo.Volunteers", "VolunteerId");
            AddForeignKey("dbo.Teenagers", "MentorId", "dbo.Mentors", "MentorId", cascadeDelete: true);
        }
    }
}
