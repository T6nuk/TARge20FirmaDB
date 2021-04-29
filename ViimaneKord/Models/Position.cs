using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class Position
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string PositionName { get; set; }
        public DateTime StartTime { get; set; }
    }
}
