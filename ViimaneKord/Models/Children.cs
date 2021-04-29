using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class Children
    {
        [Key]
        public Guid Id { get; set; }
        public string name { get; set; }
        public Employee Employee { get; set; }
    }
}
