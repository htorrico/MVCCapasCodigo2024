using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class School
    {
        
        public int SchoolID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
