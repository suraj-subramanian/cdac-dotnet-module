using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    public class Student
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string EmailId { set; get; }

    }

    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { set; get; }
    }
}