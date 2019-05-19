using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork7._1
{
    class Program
    {
        static void Main(string[] args)
        {



            var num = new[]
            {
            new[] { 5, 6, 2, 3, 6 },
            new[] { 1, 3, 5, 9 },
            new[] { 5, 5, 6, 6 },
            null,
            new[] { 6, 7, 9 },
            new[] { 7, 9 },
            };
            /*if (num != null)*/

                for (int i = 0; i < 6; i++)
                {
                  var num1 = num[i];
                  for (int j = 0; j < num1.Length; j++)

                    num1[j] += num1[j];
 
                        Console.WriteLine($"Days {num[i]}, average mark {num1} ");

                }
            Console.ReadKey();
        }
    }
}
