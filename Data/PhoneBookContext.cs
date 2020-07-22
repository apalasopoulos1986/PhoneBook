using System;
using PhoneBook.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneBook.Data
{
    public class PhoneBookContext : DbContext
    {

        public PhoneBookContext()
              : base("PhoneBookContext")
        {
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public static PhoneBookContext Create()
        {
            return new PhoneBookContext();
        }
    }
}