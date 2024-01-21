using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment1.Models
{
    public class Shipping
    {
        [Required]
        public int ShippingRateID { get; set; }

        [Required]
        public string FromCity { get; set; }

        [Required]
        public string FromCountry { get; set; }

        [Required]
        public string ToCity { get; set; }

        [Required]
        public string ToCountry { get; set; }

        [Required]
        public decimal ShippingRate { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public int TransitTime { get; set; }

        [Required]
        public int LastUpdatedBy { get; set; }
    }
}
