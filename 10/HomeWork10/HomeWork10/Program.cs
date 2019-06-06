using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            var nameFist = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            int yearsFist = int.Parse(Console.ReadLine());

            Man num = new Man() { Name = nameFist, Age = yearsFist };
           
                       
            Console.WriteLine($"{num.Name}, {num.Age} ");
            Console.ReadKey();
        }
    }
}
