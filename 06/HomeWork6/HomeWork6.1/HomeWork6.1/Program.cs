using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            double summ = 0;
            double percent = 0;
            double summEnd = 0;

            try
            {

            Console.WriteLine("Enter the amount of the down payment:");
            summ = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the daily percentage of revenue as a decimal:");
            percent = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the desired amount of accumulation:");
            summEnd = double.Parse(Console.ReadLine());

          
                while(true)
                {
                    if (percent > 1)
                    {
                        Console.WriteLine("Incorrect input of percent, please try again!");
                        percent = double.Parse(Console.ReadLine());
                        continue;
                    }

                    summ = summ + (summ * percent );
                    i++;

                    if (summ >= summEnd)
                    {
                        Console.WriteLine($"Required number of days to accumulate the desired amount: {i}");
                        break;
                    }

                }
                Console.ReadKey();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Data entered incorrectly, try again");
            }
            catch (FormatException)
            {
                Console.WriteLine("Data entered incorrectly, try again");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Data entered incorrectly, try again");
            }

        }
    }
}
