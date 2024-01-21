using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class DeliveryCharge
    {
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Number of Books Overdue")]
        [Range(1, 10, ErrorMessage =
        "Invalid value! Please enter a value from 1 to 10")]
        public int NumBooksOverdue { get; set; }
        // To do . . .
        // Define the following 3 properties with the display annotation 
        // NumDaysOverdue: int; display name: "Number of Days Overdue"
        // FineRate: double; display name: "Fine Rate (SGD)"; display format:
        // 2 decimal places and comma at the thousand mark;
        // ApplyFormatInEditMode = true
        // FineAmt: double; display name: "Fine (SGD)"; 
        // display format: same as FineRate
        
        [Display(Name = "Number of Days Overdue")]
        public int NumDaysOverdue { get; set; }


        [Display(Name = "Fine Rate (SGD)")]
        [DisplayFormat(DataFormatString = "{0:#,##0.00}", ApplyFormatInEditMode = true)]
        public double FineRate { get; set; }

        [Display(Name ="Fine (SGD)")]
        [DisplayFormat(DataFormatString = "{0:#,##0.00}")]
        public double FineAmt { get; set; }

    }
}
