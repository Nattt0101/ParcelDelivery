using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment1.Models
{
    public class PaymentTransaction
    {

        [Display(Name = "Transaction ID")]
        public int TransactionID { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Parcel ID")]
        public int ParcelID { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "AmtTran")]
        public double AmtTran { get; set; }

        public double DeliveryCharge { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Currency")]
        public string Currency { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Tran Type")]
        public string TranType { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Tran Date")]
        public DateTime TranDate { get; set; }
    }
}
