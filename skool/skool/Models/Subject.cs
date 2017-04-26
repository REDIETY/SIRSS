using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace skool.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }

        public string Subjectname { get; set; }

        public int Subjectcode { get; set; }

        public virtual Conduct conduct { get; set; }
    }
}