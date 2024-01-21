using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class CashVoucher
    {
        [Display(Name = "CashVoucher ID")]
        [Required]
        public int CashVoucherID { get; set; }

        [Display(Name = "Staff ID")]
        [Required]
        public int StaffID { get; set; }

        public double Amount { get; set; }

        public string Currency { get; set; }

        [Display(Name = "Issuing Code")]
        [Required]
        public string IssuingCode { get; set; }

        [Display(Name = "Receiver Name")]
        [Required]
        public string ReceiverName { get; set; }

        [Display(Name = "Receiver Tel No")]
        [Required]
        public string ReceiverTelNo { get; set; }

        public DateTime DateTimeIssued { get; set; }

        public string Status { get; set; }
        
    }
}
