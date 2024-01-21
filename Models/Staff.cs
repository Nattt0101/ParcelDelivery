using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment1.Models
{
    public class Staff
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "StaffID is required")]
        public int StaffId { get; set; }

        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        [Display(Name = "Name")]
        [Required]
        public string StaffName { get; set; }

        [StringLength(20)]
        [Required]
        public string LoginID { get; set; }

        [StringLength(25)]
        [Required]
        public string Password { get; set; }   

        [StringLength(50)]  
        public string Appointment { get; set; }

        [StringLength(20)]
        public string OfficeTelNo { get; set; }

        [StringLength(50)]
        public string Location { get; set; }
    }
}
