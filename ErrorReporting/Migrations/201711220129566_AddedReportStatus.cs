namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReportStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.BugReports", "Status_Id", c => c.Byte());
            CreateIndex("dbo.BugReports", "Status_Id");
            AddForeignKey("dbo.BugReports", "Status_Id", "dbo.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BugReports", "Status_Id", "dbo.Status");
            DropIndex("dbo.BugReports", new[] { "Status_Id" });
            DropColumn("dbo.BugReports", "Status_Id");
            DropTable("dbo.Status");
        }
    }
}
