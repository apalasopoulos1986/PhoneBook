using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PhoneBook.Data.Entities;
using PhoneBook.Models;

namespace PhoneBook.Controllers
{
    public class ContactsAPIController : ApiController
    {
        private MyDatabase db = new MyDatabase();

        public IHttpActionResult GetContacts()
        {
            var AllContacts = db.Contacts.ToList();

            var AllContactsWithLocation = AllContacts.Select(x => new
            {
                id = x.ContactId,
                name = x.Name,
                surname = x.Surname,
                email = x.Email,
                fixedphone = x.FixedPhone,
                mobilephone = x.MobilePhone,
                address = x.Location.AddressName,
                no = x.Location.No,
                area = x.Location.Area,
                city=x.Location.City


            });


            return Ok(AllContactsWithLocation);
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContactExists(int id)
        {
            return db.Contacts.Count(e => e.ContactId == id) > 0;
        }
    }
}