namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingReportStatus : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status(Id, StatusName) VALUES(1, 'Pending')");
            Sql("INSERT INTO Status(Id, StatusName) VALUES(2, 'In Progress')");
            Sql("INSERT INTO Status(Id, StatusName) VALUES(3, 'Resolved')");
        }
        
        public override void Down()
        {
        }
    }
}
