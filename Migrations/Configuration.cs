namespace PhoneBook.Migrations
{
    using PhoneBook.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneBook.Models.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PhoneBook.Models.MyDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Contact c1 = new Contact() { Name = "Tasos", Surname = "Palasopoulos", Email = "a_palasopoulos@yahoo.com", FixedPhone = "2108660780", MobilePhone = "6976746249" };
            Contact c2 = new Contact() { Name = "Vasileios", Surname = "Polonyfis", Email = "polonyfis@yahoo.com", FixedPhone = "2108667825", MobilePhone = "6977040862" };
            Location l1 =new Location() { AddressName = "Υμηττού", No = "130", ZipCode = "11634", Latitude = "37.9659734", Longitude = "23.7451387", City = "Αθήνα", Area = "Παγκράτι" };
            
            //Corelation location with multiple contacts and initilization
            l1.Contacts = new List<Contact>() { c1,c2 };
            context.Locations.AddOrUpdate(x => x.AddressName, l1);
        }
    }
}
