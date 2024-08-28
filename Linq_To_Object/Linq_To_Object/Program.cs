using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3,2, 4,2,6,5,6,7 ,8,9,10};

            IEnumerable<int> evenNumber = from number in numbers
                                          where  number % 2 == 0
                                          orderby number
                                          select number;

            foreach (var item in evenNumber)
            {
                Console.WriteLine("The Even Number is: " + item);
            }

            //Console.ReadKey();

            Console.WriteLine();

            /////////////////////////////////

            List<employee> list = new List<employee>
            {
               new employee  { Id = 1, FirstName = "Mehedi", LastName = "Hassan", Email = "m@mail.com" , sallary = 9800},
               new employee  { Id = 2, FirstName = "Zaved", LastName = "Hassan", Email = "z@mail.com" ,sallary = 11000},
               new employee  { Id = 3, FirstName = "Mohin", LastName = "Hassan", Email = "m@mail.com" , sallary = 15000}
            };



            //Query With name
            IEnumerable<employee> employwelist = from employ in list
                                                 where employ.FirstName  == "Mehedi" && employ.LastName == "Hassan"
                                                 select employ;

            Console.WriteLine("Query With Sallary\n");

            foreach (var item in employwelist)
            {
                Console.WriteLine($"Employee List: Id = {item.Id} Name = {item.FirstName} LastName = {item.LastName} Emai = {item.Email}\n");
            }

            //Query With Sallary

            IEnumerable<employee> employeesSallsry = from employ in list
                                                     where employ.sallary >= 10000
                                                     orderby employ.sallary
                                                     select employ;

            Console.WriteLine("Query With Sallary\n");

            foreach (var item in employeesSallsry)
            {
                Console.WriteLine($"Employee List: Id = {item.Id} Name = {item.FirstName} LastName = {item.LastName} Emai = {item.Email} Ssllary = {item.sallary}");
            }


            Console.ReadKey();
        }
    }

    public class employee
    {
       public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; }

        public int sallary { get; set; }

    }
}
