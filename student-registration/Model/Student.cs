using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace student_registration.Models
{
    public class Student
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string FirstName { get; set; }
         [Required]
        public string LastName { get; set; }
         [Required]
        public string Telephone { get; set; }
         [Required]
        public string Email { get; set; }
         [Required]
        public string Address { get; set; }
        public DateTime DOB { get; set; }
    }
}