using System;

namespace ViimaneKord
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EmployeeContext())
            {
                db.Employees.Add(new Employee { FirstName = "Michael", LastName = "Scott" });
                db.SaveChanges();

                foreach (var employee in db.Employees)
                {
                    Console.WriteLine(employee.FirstName, employee.LastName);
                }
            }

            Console.WriteLine("Välju");
            Console.ReadKey();
        }
    }
}
