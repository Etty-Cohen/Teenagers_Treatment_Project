namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableMentorAppointments : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "MentorId", "dbo.Mentors");
            AddForeignKey("dbo.Appointments", "MentorId", "dbo.Mentors", "MentorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "MentorId", "dbo.Mentors");
            AddForeignKey("dbo.Appointments", "MentorId", "dbo.Mentors", "MentorId", cascadeDelete: true);
        }
    }
}
