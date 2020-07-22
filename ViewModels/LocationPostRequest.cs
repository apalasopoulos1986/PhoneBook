using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web;

namespace PhoneBook.ViewModels
{
    public class LocationPostRequest : IValidatableObject
    {
        [MinLength(4, ErrorMessage = "Minimum length=4 characters")]
        [MaxLength(20, ErrorMessage = "Maximum length=20 characters")]
        public string Province { get; set; }


        [MinLength(4, ErrorMessage = "Minimum length=4 characters")]
        [MaxLength(20, ErrorMessage = "Maximum length=20 characters")]
        public string Area { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            string provinceRegex = "^[0-3]{4,20}$";
            if (!string.IsNullOrEmpty(Province))
            {
                if (!Regex.Match(Province, provinceRegex).Success)
                {
                    yield return new ValidationResult(
                       $"This is not a valid province name ",
                       new[] { nameof(Province) });
                }
            }
            string areaRegex = "^[0-3]{4,20}$";
            if (!string.IsNullOrEmpty(Area))
            {
                if (!Regex.Match(Area, areaRegex).Success)
                {
                    yield return new ValidationResult(
                       $"This is not a valid area name ",
                       new[] { nameof(Area) });
                }
            }
        }
    }
}