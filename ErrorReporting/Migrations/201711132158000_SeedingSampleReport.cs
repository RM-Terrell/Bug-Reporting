namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingSampleReport : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT BugReports ON" +
                " " +
                "INSERT INTO BugReports(Id, Name, ErrorMessage, Severity, BrowserId, Description, Reproduction, OperatingSystemId)" +
                " VALUES(1, 'Seed Name', 'Seed Error Message', 1, 1, 'Seed Description', 'Seed Repro', 1)" +
                " " +
                "SET IDENTITY_INSERT BugReports OFF");

        }

        public override void Down()
        {
        }
    }
}
