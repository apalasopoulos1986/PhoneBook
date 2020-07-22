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
        [Key]
        public Guid Id { get; set; }
        public string Province { get; set; }
        public string Area { get; set; }
        #endregion
    }
}