using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessObject.Model
{
    public class Student
    {
        public int StudentID { get; set; }
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
        //[StringLength(50)]
        //[Column("Age")]
        //[Display(Name = "Age")]


        public string Age { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("Sex")]
        //[Display(Name = "Sex")]

        public string Sex { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("Status")]
        //[Display(Name = "Status")]
        public string Status { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("Section")]
        //[Display(Name = "Section")]
        public string Section { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("Classroom")]
        //[Display(Name = "Classroom")]
        public string Classroom { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("Emergency Contact")]
        //[Display(Name = "EmergencyContact")]
        public string EmergencyContact { get; set; }

        //[Required]
        //[StringLength(50)]
        //[Column("Kebele")]
        //[Display(Name = "Kebele")]
        public string Kebele { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("Woreda")]
        //[Display(Name = "Woreda")]
        public string Woreda { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("SubCity")]
        //[Display(Name = "SubCity")]
        public string SubCity { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Column("HouseNo")]
        //[Display(Name = "HouseN0")]
        public string HouseNo { get; set; }
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


        public virtual ICollection<School> schools { get; set; }
    }
}
