using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class UpdateShipping
    {
        [Display(Name = "ShippingRate ID")]
        public int shippingRateID { get; set; }

        [Display(Name = "From City")]
        public string fromCity { get; set; }

        [Display(Name = "From Country")]
        public string fromCountry { get; set; }

        [Display(Name = "To City")]
        public string toCity { get; set; }

        [Display(Name = "To Country")]
        public string toCountry { get; set; }

        [Display(Name = "Shipping Rate")]
        public double shippingRate { get; set; }

        public string Currency { get; set; }

        [Display(Name = "Transit Time")]
        public int transitTime { get; set; }

        [Display(Name = "Last Updated By")]
        public string lastUpdated { get; set; }
    }
}
