using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class Branch
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Location { get; set; }
        public Company Companies { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
