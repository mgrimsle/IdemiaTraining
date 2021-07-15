namespace DMV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DriverDataModels",
                c => new
                    {
                        Driver_ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Driver_ID);
            
            CreateTable(
                "dbo.DriversLicenseDataModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Status = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        DriverId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DriversLicenseDataModels");
            DropTable("dbo.DriverDataModels");
        }
    }
}
