using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Textbook_Management.Models
{
    public class Course
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }

        
        public Department Department { get; set; }
        public int Did { get; set; }

        public List<Book> Books { get; set; }
    }
}
