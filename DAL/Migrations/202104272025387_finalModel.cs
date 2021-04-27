namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "IsActive");
            DropColumn("dbo.Mentors", "IsActive");
            DropColumn("dbo.Teenagers", "IsActive");
            DropColumn("dbo.Volunteers", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Volunteers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teenagers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mentors", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Admins", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
