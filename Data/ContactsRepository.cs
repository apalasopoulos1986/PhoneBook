using PhoneBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.Data
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly PhoneBookContext _ctx;

        public ContactsRepository(PhoneBookContext ctx)
        {
            _ctx = ctx;
        }
        public void AddEntity(Contact contact)
        {
            _ctx.Contacts.Add(contact);
        }

        public void DeleteContactById(Guid id)
        {
            var contact = _ctx.Contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                _ctx.Contacts.Remove(contact);
            }
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            try
            {
                return _ctx.Contacts.ToList();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Contact GetContactById(Guid id)
        {
            return _ctx.Contacts.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}