using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AZD_Company.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        [Display(Name = "Registered Date")]
        public DateTime? R_Date { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        [Display(Name = "End Date")]
        public DateTime? E_Date { get; set; }

        [Display(Name = "Department ID")]
        public int DepartmetnID { get; set; }

        [Display(Name = "Salary")]
        public int Salary { get; set; }


    }


    public class Customer
    {
       
        [Key]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }



       

    }
}