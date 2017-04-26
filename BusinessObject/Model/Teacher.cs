using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Model
{
    public class Teacher
    {
        public int TeacherID { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        //[Column("FirstName")]
        //[Display(Name = "FirstName")]
        public string FirstName { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "Middle Name cannot be longer than 50 characters.")]
        //[Column("MiddleName")]
        //[Display(Name = "MiddleName")]
        public string MiddleName { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Display(Name = "Last Name")]
        public string LastName { get; set; }


        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
        //ApplyFormatInEditMode = true)]
        //[Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }


        //[Required]
        //[StringLength(50, ErrorMessage = "Assigned Subject cannot be longer than 50 characters.")]
        //[Column("Assigned Subject")]
        //[Display(Name = "Assigned Subject")]
        public string AssignedSubject { get; set; }


        //[Required]
        //[StringLength(50, ErrorMessage = "User name cannot be longer than 50 characters.")]
        //[Column("username")]
        //[Display(Name = "username")]
        public string username { get; set; }

        //[Required(ErrorMessage = "Password is required.")]
        //[DataType(DataType.Password)]
        public string password { get; set; }
        //[Compare("password", ErrorMessage = "please confirm your password")]
        //[DataType(DataType.Password)]
        public string Confirmpassword { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<School> Schools { get; set; }

    }
}
