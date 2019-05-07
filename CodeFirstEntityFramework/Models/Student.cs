using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEntityFramework.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Firstname required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Enter Minimum Lenght 3 with a Maximum of 20 Characters")]
     [RegularExpression(@"(\S)+", ErrorMessage = "cannot Start with an empty spaces")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Enter Minimum Lenght 3 with a Maximum of 20 Characters")]
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "cannot Start with an empty spaces")]

        public string LastName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}