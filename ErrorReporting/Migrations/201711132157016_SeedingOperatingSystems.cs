namespace ErrorReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingOperatingSystems : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO OperatingSystems(Id, OperatingSystemName) VALUES(1, 'Windows')");
            Sql("INSERT INTO OperatingSystems(Id, OperatingSystemName) VALUES(2, 'MacOS')");
            Sql("INSERT INTO OperatingSystems(Id, OperatingSystemName) VALUES(3, 'iOS')");
            Sql("INSERT INTO OperatingSystems(Id, OperatingSystemName) VALUES(4, 'Linux')");

        }

        public override void Down()
        {
        }
    }
}
