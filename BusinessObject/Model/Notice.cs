using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Model
{
    public class Notices
    {

        public int ID { get; set; }

        //[Required]
        //[Column("Title")]
        //[Display(Name = "Title")]
        public String Title { get; set; }

        //[Required]
        //[Column("description")]
        //[Display(Name = "description")]
        public String description { get; set; }
    }
}
