using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Text;
using ViimaneKord.Models;

namespace ViimaneKord
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Children> Childrens { get; set; }
        public ICollection<Access> Accesses { get; set; }
        public ICollection<Lending> Lendings { get; set; }
        public ICollection<Sick_leave> sick_Leaves { get; set; }
        public ICollection<Vacation_leave> vacation_Leaves { get; set; }
        public ICollection<Position> Positions { get; set; }
        public ICollection<HealthCheckList> HealthCheckLists { get; set; }
    }
}
