namespace PhoneBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        FixedPhone = c.String(),
                        MobilePhone = c.String(),
                        LocationId = c.Int(),
                    })
                .PrimaryKey(t => t.ContactId)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        AddressName = c.String(nullable: false),
                        No = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        City = c.String(nullable: false),
                        Area = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "LocationId", "dbo.Locations");
            DropIndex("dbo.Contacts", new[] { "LocationId" });
            DropTable("dbo.Locations");
            DropTable("dbo.Contacts");
        }
    }
}
