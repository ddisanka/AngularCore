using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace student_registration.Models
{
    public class StudentContext : DbContext

    {
       public StudentContext(DbContextOptions<StudentContext> options): base(options)
       {
           
       }
        public DbSet<Student> Students { get; set; }
        

        
    }
}