using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace PhoneBook.Data.Entities
{
    public class Contact
    {
        #region Contact_Properties
       
        public int ContactId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string FixedPhone { get; set; }

        public string MobilePhone { get; set; }

        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }

        #endregion

    }
}