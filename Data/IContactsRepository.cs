using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneBook.Data.Entities;

namespace PhoneBook.Data
{
    public interface IContactsRepository
    {
        #region CrudContactsInterface  
        IEnumerable<Contact> GetAllContacts();
        void AddEntity(Contact contact);
        bool SaveAll();
        Contact GetContactById(Guid id);
        void DeleteContactById(Guid id);
        #endregion
    }
}