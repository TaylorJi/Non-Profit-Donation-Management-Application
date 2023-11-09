using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Models
{
    public class ContactList
    {
        [Key]
        public int AccountNo { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Invalid Name. Only alphabets and spaces are allowed.")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Invalid Name. Only alphabets and spaces are allowed.")]
        public string? LastName { get; set; }
        [Required]
        [RegularExpression(@"^.+@.+..+$", ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        [Display(Name = "Postal Code")]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d$", ErrorMessage = "Invalid Postal Code")]
        public string? PostalCode { get; set; }
        [Required]
        public string? Country { get; set; }

        //internal update

        [ScaffoldColumn(false)]
        public DateTime? Created { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? Modified { get; set; }

        [ScaffoldColumn(false)]
        public string? CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public string? ModifiedBy { get; set; }
    }
}