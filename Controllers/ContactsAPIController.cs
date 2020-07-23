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

        // GET: api/ContactsAPI
        //public IQueryable<Contact> GetContacts()
        //{
        //    return db.Contacts;
        //}

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

        // GET: api/ContactsAPI/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult GetContact(int id)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // PUT: api/ContactsAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContact(int id, Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contact.ContactId)
            {
                return BadRequest();
            }

            db.Entry(contact).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ContactsAPI
        [ResponseType(typeof(Contact))]
        public IHttpActionResult PostContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Contacts.Add(contact);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contact.ContactId }, contact);
        }

        // DELETE: api/ContactsAPI/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult DeleteContact(int id)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            db.Contacts.Remove(contact);
            db.SaveChanges();

            return Ok(contact);
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