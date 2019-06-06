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
            var i = 0;
            while(i < 3)
            {
                string nameFist ;
                int yearsFist = 0;

                Console.WriteLine("Enter your name : ");
                nameFist = Console.ReadLine();
                Console.WriteLine("Enter your age :");
                yearsFist = int.Parse(Console.ReadLine());

                Man num = new Man() { Name = nameFist, Age = yearsFist };


                Console.WriteLine($"  {num.Name}, {yearsFist}, {num.Age} ");
                Console.ReadKey();
                i++;
            }
            
            
        }
    }
}
