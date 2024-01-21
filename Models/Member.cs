using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Member
    {
        public int MemberID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Salutation { get; set; }

        [Required]
        public string TelNo { get; set; }

        [Required]
        public string EmailAddr { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? City { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
