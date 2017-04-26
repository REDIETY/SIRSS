using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace skool.Models
{
    public class Parent
    {
        public int ParentID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Middle Name cannot be longer than 50 characters.")]
        [Column("MiddleName")]
        [Display(Name = "MiddleName")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }


    
        [Required]
        [StringLength(50)]
        [Column("phone number")]
        [Display(Name = "phone number")]
        public string phonenumber { get; set; }

        [Required]
        [StringLength(50)]
        [Column("HouseNo")]
        [Display(Name = "HouseN0")]
        public string HouseNo { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "User name cannot be longer than 50 characters.")]
        [Column("username")]
        [Display(Name = "username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Compare("password", ErrorMessage = "please confirm your password")]
        [DataType(DataType.Password)]
        public string Confirmpassword { get; set; }

        public virtual Student Student { get; set; }
    }
}