using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace Assignment1.Models
{
    public class Login

    {
        [Required(ErrorMessage = "Field cannot be empty")]
        public string LoginID { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        public string Password { get; set; }
    }
}
