using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.Data.Entities
{
    public class Location
    {
        #region Location_Properties
        
        public int LocationId { get; set; }


        [Required(ErrorMessage = "Απαιτείται διεύθυνση")]
        [Display(Name = "Διεύθυνση")]
        public string AddressName { get; set; }

        [Required(ErrorMessage = "Απαιτείται αριθμός")]
        [Display(Name = "Αριθμός")]
        public string No { get; set; }

        [Required(ErrorMessage = "Απαιτείται ταχυδρομικός κώδικας")]
        [Display(Name = "Ταχυδρομικός κώδικας")]
       
        [MaxLength(5)]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Ο ταχυδρομικός κώδικας πρέπει ναναι 5 ψήφιος αριθμός")]
        public string ZipCode { get; set; }

        [Display(Name = "Γεωγραφικό μήκος 'Latitude'")]
        public string Latitude { get; set; } //geografiko mikos 
        [Display(Name = "Γεωγραφικό πλάτος 'Longitude'")]
        public string Longitude { get; set; } //geografiko platos
        [Required(ErrorMessage = "Απαιτείται όνομα πόλης")]
        [Display(Name = "Πόλη")]
        public string City { get; set; }

        [Required(ErrorMessage = "Απαιτείται όνομα περιοχής")]
        [Display(Name = "Περιοχή")]
        public string Area { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        #endregion
    }
}