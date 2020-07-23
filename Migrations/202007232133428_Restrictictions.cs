namespace PhoneBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Restrictictions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "MobilePhone", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "ZipCode", c => c.String(nullable: false, maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "MobilePhone", c => c.String());
            AlterColumn("dbo.Contacts", "Surname", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String());
        }
    }
}
