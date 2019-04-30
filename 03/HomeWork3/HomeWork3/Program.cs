using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter your name : ");
             var name1 = Console.ReadLine();
             Console.WriteLine("Enter your age :");
             int num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter your name : ");
             var name2 = Console.ReadLine();
             Console.WriteLine("Enter your age :");
             int num2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter your name : ");
             var name3 = Console.ReadLine();
             Console.WriteLine("Enter your age :");
             int num3 = int.Parse(Console.ReadLine());


             string[] num = new string[3];
            
                num[0] = name1;
                num[1] = name2;
                num[2] = name3;
                                            
             int[] years = new int[3];

                years[0] = num1 + 4;
                years[1] = num2 + 4;
                years[2] = num3 + 4;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Name:{num[i]}, age in 4 years:{years[i]}");
            }
          
            Console.ReadKey();                                                         
        }                                                                                
    }                                                                                       
}                                                                                           
