namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingBrowsers : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Browsers(Id, BrowserName) VALUES(1, 'Firefox')");
            Sql("INSERT INTO Browsers(Id, BrowserName) VALUES(2, 'Chrome')");
            Sql("INSERT INTO Browsers(Id, BrowserName) VALUES(3, 'Safari')");
            Sql("INSERT INTO Browsers(Id, BrowserName) VALUES(4, 'Edge')");

        }

        public override void Down()
        {
        }
    }
}
