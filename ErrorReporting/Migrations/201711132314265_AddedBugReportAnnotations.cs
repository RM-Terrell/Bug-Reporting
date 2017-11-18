namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBugReportAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BugReports", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.BugReports", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.BugReports", "Reproduction", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BugReports", "Reproduction", c => c.String());
            AlterColumn("dbo.BugReports", "Description", c => c.String());
            AlterColumn("dbo.BugReports", "Name", c => c.String());
        }
    }
}
