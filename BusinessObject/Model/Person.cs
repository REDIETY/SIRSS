using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Model
{
    public class Person
    {
        //[Key]
        public int userId { get; set; }

        //[Required(ErrorMessage = "first Name is required.")]
        public string firstName { get; set; }

        //[Required(ErrorMessage = "Middle Name is required.")]
        public string MiddleName { get; set; }

        //[Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "User Name is required.")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Password is required.")]
        //[DataType(DataType.Password)]
        public string password { get; set; }
        //[Compare("password", ErrorMessage = "please confirm your password")]
        //[DataType(DataType.Password)]
        public string Confirmpassword { get; set; }

        public string Name { get; set; }
    }
}
