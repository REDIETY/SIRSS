﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace skool.Models
{
    public class Admin
    {

        public int AdminID { get; set; }


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
        public virtual ICollection<School> Schools { get; set; }
    }
}