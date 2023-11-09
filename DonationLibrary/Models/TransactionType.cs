using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Models
{
    public class TransactionType
    {
        [Key]
        [Display(Name = "Transaction Type Id")]
        public int TransactionTypeId { get; set; }
        [Display(Name = "Transaction Type")]
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }

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