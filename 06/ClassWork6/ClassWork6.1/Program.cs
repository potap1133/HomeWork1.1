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

            //var num2 = 0;
            //var num1 = 0;

            double num5 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                double num2 = 0;
                //var num1 = 0;
                if (num[i] == null)
                {
                    Console.WriteLine("The average mark for day: N/A");
                    continue;
                }

                var num3 = i;
                var num1 = num[i];
                for (int j = 0; j < num1.Length; j++)
                {

                     num2 += (double) (num1[j] * 1.0 / num1.Length);
                     
                }
                num5 = (num2 + num2) / num.Length;
                Console.WriteLine("The average mark for day: {0} is {1:f}", num3, num2);
                
                continue;                
            }
            Console.WriteLine("The average mark for week: {0:f} ", num5 );

            Console.ReadKey();
        }
    }
}
