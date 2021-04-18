namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableAdminMentor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mentors", "AdminId", "dbo.Admins");
            AddForeignKey("dbo.Mentors", "AdminId", "dbo.Admins", "AdminId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mentors", "AdminId", "dbo.Admins");
            AddForeignKey("dbo.Mentors", "AdminId", "dbo.Admins", "AdminId", cascadeDelete: true);
        }
    }
}
