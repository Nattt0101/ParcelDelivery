using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment1.Models
{
    public class Record
    {

        public int RecordID { get; set; }
        public int ParcelID { get; set; }

        [StringLength(255)]


        [Required(ErrorMessage = "Field cannot be empty")]
        public string Description { get; set; }
    }
}
