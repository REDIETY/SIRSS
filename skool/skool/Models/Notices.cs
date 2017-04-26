using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace skool.Models
{
    public class Notices
    {

        public int ID { get; set; }

        [Required]
        [Column("Title")]
        [Display(Name = "Title")]
        public String Title { get; set; }

        [Required]
        [Column("description")]
        [Display(Name = "description")]
        public String description { get; set; }
    }
}