using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public int RegNum { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public ICollection<Branch> Branches { get; set; }
    }
}
