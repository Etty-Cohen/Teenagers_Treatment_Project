namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteIdNumberFromUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "IdNumber");
            DropColumn("dbo.Mentors", "IdNumber");
            DropColumn("dbo.Teenagers", "IdNumber");
            DropColumn("dbo.Volunteers", "IdNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Volunteers", "IdNumber", c => c.String());
            AddColumn("dbo.Teenagers", "IdNumber", c => c.String());
            AddColumn("dbo.Mentors", "IdNumber", c => c.String());
            AddColumn("dbo.Admins", "IdNumber", c => c.String());
        }
    }
}
