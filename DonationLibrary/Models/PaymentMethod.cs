using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Models
{
    public class PaymentMethod
    {
        [Key]
        [Display(Name = "Payment Method Id")]
        public int PaymentMethodId { get; set; }
        [Display(Name = "Payment Method")]
        [Required]
        public string? Name { get; set; }

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