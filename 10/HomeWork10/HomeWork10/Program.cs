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
            var yearsFist = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your name : ");
            var nameSecond = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            var yearsSecond = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your name : ");
            var nameThird = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            var yearsThird = int.Parse(Console.ReadLine());



            Man num = new Man()
            {
                Name = nameFist,
                Name1 = nameSecond,
                Name2 = nameThird                
            };

            Man num1 = new Man()
            {
                Age = yearsFist,
                Age1 = yearsSecond,
                Age2 = yearsThird,
            };

            for (int i = 0; i <  3; i++)
            {
                Console.WriteLine($"  {num.Name[i]}, {num1.Age[i]} ");
            }





                
                Console.ReadKey();

            
            
            
        }
    }
}
