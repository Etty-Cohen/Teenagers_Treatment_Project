namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateClassVolunteerTeenager : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VolunteerTeenagers",
                c => new
                    {
                        Volunteer_VolunteerId = c.Int(nullable: false),
                        Teenager_TeenagerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Volunteer_VolunteerId, t.Teenager_TeenagerId })
                .ForeignKey("dbo.Volunteers", t => t.Volunteer_VolunteerId, cascadeDelete: true)
                .ForeignKey("dbo.Teenagers", t => t.Teenager_TeenagerId, cascadeDelete: true)
                .Index(t => t.Volunteer_VolunteerId)
                .Index(t => t.Teenager_TeenagerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VolunteerTeenagers", "Teenager_TeenagerId", "dbo.Teenagers");
            DropForeignKey("dbo.VolunteerTeenagers", "Volunteer_VolunteerId", "dbo.Volunteers");
            DropIndex("dbo.VolunteerTeenagers", new[] { "Teenager_TeenagerId" });
            DropIndex("dbo.VolunteerTeenagers", new[] { "Volunteer_VolunteerId" });
            DropTable("dbo.VolunteerTeenagers");
        }
    }
}
