namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOccurrenceAndSubmissionDates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BugReports", "BugOccurrenceDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BugReports", "SubmissionDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BugReports", "SubmissionDate");
            DropColumn("dbo.BugReports", "BugOccurrenceDate");
        }
    }
}
