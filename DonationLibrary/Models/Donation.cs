using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonationLibrary.Models
{
    public class Donation
    {
        [Key]
        public int TransId { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Display(Name = "Account Email")]
        public int? AccountNo { get; set; }
        [Display(Name = "Account Email")]
        [ForeignKey("AccountNo")]
        public ContactList? ContactList { get; set; }
        [Display(Name = "Transaction Type")]
        public int? TransactionTypeId { get; set; }
        [Display(Name = "Transaction Type")]
        [ForeignKey("TransactionTypeId")]
        public TransactionType? TransactionType { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public float? Amount { get; set; }
        [Display(Name = "Payment Method")]
        public int? PaymentMethodId { get; set; }
        [Display(Name = "Payment Method")]
        [ForeignKey("PaymentMethodId")]
        public PaymentMethod? PaymentMethod { get; set; }
        public string? Notes { get; set; }

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