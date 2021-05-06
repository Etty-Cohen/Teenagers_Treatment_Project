namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeMailUnique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "MailAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mentors", "MailAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.Teenagers", "MailAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.Volunteers", "MailAddress", c => c.String(maxLength: 50));
            CreateIndex("dbo.Admins", "MailAddress", unique: true);
            CreateIndex("dbo.Mentors", "MailAddress", unique: true);
            CreateIndex("dbo.Teenagers", "MailAddress", unique: true);
            CreateIndex("dbo.Volunteers", "MailAddress", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Volunteers", new[] { "MailAddress" });
            DropIndex("dbo.Teenagers", new[] { "MailAddress" });
            DropIndex("dbo.Mentors", new[] { "MailAddress" });
            DropIndex("dbo.Admins", new[] { "MailAddress" });
            AlterColumn("dbo.Volunteers", "MailAddress", c => c.String());
            AlterColumn("dbo.Teenagers", "MailAddress", c => c.String());
            AlterColumn("dbo.Mentors", "MailAddress", c => c.String());
            AlterColumn("dbo.Admins", "MailAddress", c => c.String());
        }
    }
}
