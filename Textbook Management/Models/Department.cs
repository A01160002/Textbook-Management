using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Textbook_Management.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        public string Dname { get; set; }

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; } 

    }
}
