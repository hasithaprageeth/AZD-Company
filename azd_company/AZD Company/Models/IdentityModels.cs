using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AZD_Company.Models;
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace AZD_Company.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        
        [StringLength(50, ErrorMessage = "Please Enter the First Name", MinimumLength = 1)]
        [Display(Name = "First Name")]
        public string f_name { get; set; }

        
        [StringLength(100, ErrorMessage = "Please Enter the Last Name", MinimumLength = 1)]
        [Display(Name = "Last Name")]
        public string l_name { get; set; }

        
        [StringLength(100, ErrorMessage = "Please Enter the Address", MinimumLength = 1)]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Display(Name = "Telephone Number")]
        public int Telephone { get; set; }

    }

    public class MyApplicationRole : IdentityRole
    {
        public MyApplicationRole()
        {

        }

        public MyApplicationRole(string roleName, string description)
            : base(roleName)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }




    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
      
    }






}