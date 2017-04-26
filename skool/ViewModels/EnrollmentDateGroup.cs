using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace skool.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public String Title { get; set; }
        public String description { get; set; }
        public int StudentCount { get; set; }
        public int TeacherCount { get; set; }
    }
}