using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Model
{
    public class Subject
    {
        public int SubjectID { get; set; }

        public string Subjectname { get; set; }

        public int Subjectcode { get; set; }

        public virtual Conduct conduct { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
