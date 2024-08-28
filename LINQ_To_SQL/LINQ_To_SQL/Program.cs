using LINQ_To_SQL.Data_Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeConnectionn context = new EmployeeConnectionn())
            {





                var sallary = from salary in context.Employee_Details
                              where salary.Sallary > 15000 && salary.Gender == "Female"
                              select salary;

                foreach (var item in sallary)
                {
                    Console.WriteLine($"Sallary Up to 15000 with Female = {item.Name} , {item.Designation}, {item.Email} , {item.Sallary}");
                }
                Console.ReadKey();
            }
        }
    }
}
