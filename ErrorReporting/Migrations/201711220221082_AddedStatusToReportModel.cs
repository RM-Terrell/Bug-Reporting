namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatusToReportModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BugReports", "StatusId", c => c.Byte(nullable: false));
            CreateIndex("dbo.BugReports", "StatusId");
            AddForeignKey("dbo.BugReports", "StatusId", "dbo.Status", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BugReports", "StatusId", "dbo.Status");
            DropIndex("dbo.BugReports", new[] { "StatusId" });
            DropColumn("dbo.BugReports", "StatusId");
        }
    }
}
