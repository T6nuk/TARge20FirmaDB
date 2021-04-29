using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViimaneKord.Models
{
    public class Lending
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Company Companies { get; set; }
        public DateTime LendingStart { get; set; }
        public DateTime LendingEnd { get; set; }
        public ICollection<Lending_Items> Lending_Items { get; set; }
    }
}
