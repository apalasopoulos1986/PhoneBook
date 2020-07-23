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
        [Required(ErrorMessage = "Απαιτείται όνομα")]
        [Display(Name = "Όνομα")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Απαιτείται επώνυμο")]
        [Display(Name = "Επώνυμο")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "To email δεν είναι έγκυρο")]
        public string Email { get; set; }
        [Display(Name = "Σταθερό Τηλέφωνο")]
        [Phone]
        public string FixedPhone { get; set; }
        [Required(ErrorMessage = "Απαιτείται κινητό τηλέφωνο")]
        [Display(Name = "Κινητό Τηλέφωνο")]
        [Phone]
        public string MobilePhone { get; set; }

        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }

        #endregion

    }
}