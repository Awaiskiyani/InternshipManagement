using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipManagement
{
    internal class Internship
    {
       
        public int Id { get; set; }
        public string? JobTitle { get; set; }
        public Company? company { get; set; }
        public InternshipDetails? Details { get; set; }
    }
}
