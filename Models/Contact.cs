using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment1.Models
{
    public class Contact
    {
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
       
        public string Email { get; set; }
        
    }
}
