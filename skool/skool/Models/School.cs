using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace skool.Models
{
    public class School
    {
        public int SchoolID { get; set; }
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public int ClassroomID { get; set; }
        public int AdminID { get; set; }

      
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Admin Admin { get; set; }
 
    }
}