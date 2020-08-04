using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_EntityFrameworkPractice
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContextDB")
        {

        }


        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentLogIn> StudentsLogIn { get; set; }
    }
}
