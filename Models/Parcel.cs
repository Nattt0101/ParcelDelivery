using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment1.Models
{
    public class Parcel
    {
        [Display(Name = "Parcel ID")]
        public int ParcelID { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]

        [Display(Name = "Item Description")]
        [StringLength(255, ErrorMessage = "Item description cannot exceed 255 characters")]

        public string ItemDescription { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [StringLength(50, ErrorMessage = "Sender name cannot exceed 50 characters")]

        [Display(Name = "Sender Name")]
        public string SenderName { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [RegularExpression(@"[689]\d{7}|\+65[689]\d{7}$", ErrorMessage = "Invalid Singapore Phone Number")]
        [StringLength(20, ErrorMessage = "Telephone number cannot exceed 20 characters")]

        [Display(Name = "Sender Telephone")]
        public string SenderTelNo { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]

        [Display(Name = "Receiver Name")]
        public string ReceiverName { get; set; }

        [RegularExpression(@"[689]\d{7}|\+65[689]\d{7}$", ErrorMessage = "Invalid Singapore Phone Number")]
        [StringLength(20, ErrorMessage = "Telephone number cannot exceed 20 characters")]
        [Display(Name = "Receiver Telephone")]
        public string ReceiverTel { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [StringLength(255, ErrorMessage = "Delivery address cannot exceed 255 characters")]
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; }

        [Required(ErrorMessage = "Please select an option")]
        [StringLength(50, ErrorMessage = "Field cannot exceed 50 characters")]
        public string FromCity { get; set; }

        [Required(ErrorMessage = "Please select an option")]
        [StringLength(50, ErrorMessage = "Field cannot exceed 50 characters")]
        public string FromCountry { get; set; }
        [Required(ErrorMessage = "Please select an option")]
        [StringLength(50, ErrorMessage = "Field cannot exceed 50 characters")]
        public string ToCity { get; set; }

        [Required(ErrorMessage = "Please select an option")]
        [StringLength(50, ErrorMessage = "Field cannot exceed 50 characters")]
        public string ToCountry { get; set; }
        public double DeliveryCharge { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        public float ParcelWeight { get; set; }

        [Required(ErrorMessage = "Field cannot be empty")]
        [StringLength(3, ErrorMessage = "Field cannot exceed 3 characters")]
        public string Currency { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime? TargetDelivery { get; set; }
        public int DeliveryStatus { get; set; }
        public int DeliveryManID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime? ReceiveDate { get; set; }
        public Parcel()
        {
            Currency = "";
        }
    }
}
