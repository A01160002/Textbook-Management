using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Textbook_Management.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Sbirth { get; set; }
        public string Sgender { get; set; }
        public string Stel { get; set; }
        public string Saddr { get; set; }

        
        public Department Department { get; set; }
        public int Did { get; set; }

    }
}
