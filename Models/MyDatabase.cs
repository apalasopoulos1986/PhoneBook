﻿using PhoneBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class MyDatabase : DbContext
    {
        public MyDatabase() : base("PhoneBookContext") { }
       
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}