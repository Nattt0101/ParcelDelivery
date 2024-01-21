using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment1.Models
{
    public class AssignViewModel
    {

        [Display(Name = "Transaction ID")]
        public int TransactionID { get; set; }

        [Display(Name = "AmtTran")]
        public double AmtTran { get; set; }
        [Display(Name = "Currency")]
        public string Currency { get; set; }
        [Display(Name = "Tran Type")]
        public string TranType { get; set; }
        [Display(Name = "Tran Date")]
        public DateTime TranDate { get; set; }

        [Display(Name = "Parcel ID")]
        [Required]
        public int ParcelID { get; set; }

        [Display(Name = "Item Description")]
        [StringLength(225)]
        public string ItemDescription { get; set; }

        [Display(Name = "Sender Name")]
        public string SenderName { get; set; }
        [Display(Name = "Sender Telephone")]
        public string SenderTelNo { get; set; }
        [Display(Name = "Receiver Name")]
        public string ReceiverName { get; set; }
        [Display(Name = "Receiver Telephone")]
        public string ReceiverTel { get; set; }
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; }
        public string FromCity { get; set; }
        public string FromCountry { get; set; }
        public string ToCity { get; set; }
        public string ToCountry { get; set; }
        public double ParcelWeight { get; set; }
        public double DeliveryCharge { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime? TargetDelivery { get; set; }
        public int DeliveryStatus { get; set; }
        public int DeliveryManID { get; set; }

        public DateTime? ReceiveDate { get; set; }


    }
}
