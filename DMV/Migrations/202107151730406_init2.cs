namespace DMV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
<<<<<<< Updated upstream:DMV/Migrations/202107151738278_init.cs
    public partial class init : DbMigration
=======
    public partial class init2 : DbMigration
>>>>>>> Stashed changes:DMV/Migrations/202107151730406_init2.cs
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Driver_ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Driver_ID);
            
            CreateTable(
                "dbo.DriversLicenses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Status = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Driver_Driver_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.Driver_Driver_ID)
                .Index(t => t.Driver_Driver_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DriversLicenses", "Driver_Driver_ID", "dbo.Drivers");
            DropIndex("dbo.DriversLicenses", new[] { "Driver_Driver_ID" });
            DropTable("dbo.DriversLicenses");
            DropTable("dbo.Drivers");
        }
    }
}
