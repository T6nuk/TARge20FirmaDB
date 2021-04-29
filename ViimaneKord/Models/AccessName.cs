using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class AccessName
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstAccess { get; set; }
        public string SecondAccess { get; set; }
        public string ThirdAccess { get; set; }
    }
}
