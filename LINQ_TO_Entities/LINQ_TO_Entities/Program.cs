using LINQ_TO_Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TO_Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeConnection context = new EmployeeConnection())
            {
                var femaleEmplye = context.Employee_Details.Where(e => e.Gender == "Female").OrderBy(o => o.Name);

                Console.WriteLine($"All female employee");
                foreach (var item in femaleEmplye)
                {
                    Console.WriteLine($"{item.Id} , {item.Name} , {item.Gender} , {item.Sallary}");
                }
                Console.ReadKey();


            }
        }
    }
}
