using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class HealthCheckList
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime CheckDate { get; set; }

    }
}
