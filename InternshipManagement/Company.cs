using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipManagement
{
    internal class Company
    {
        
        public   string? Name { get; set; }

        public string? Location { get; set; }
        
        public string? Industry { get; set; }
    }
}
