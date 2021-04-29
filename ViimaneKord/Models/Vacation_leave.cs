using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class Vacation_leave
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime VacationStart { get; set; }
        public DateTime VacationEnd { get; set; }
    }
}
