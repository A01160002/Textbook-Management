using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Textbook_Management.Models
{
    public class Book
    {
        [Key]
        public int Bid { get; set; }
        public string Bname { get; set; }
        public string Bremain { get; set; }
        public string Blaunch { get; set; }

        public Course Course { get; set; }
        public int Cid { get; set; }
    }
}
