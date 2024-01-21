using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class FeedbackEnquiry
    {

        public int FeedbackEnquiryID { get; set; }


        public int MemberID { get; set; }

        [StringLength(255)]
        public string Content { get; set; }
        public DateTime DateTimePosted { get; set; }
        public int StaffID { get; set; }

        [StringLength(225)]
        public string Response { get; set; }
        public string Status { get; set; }
    }
}
