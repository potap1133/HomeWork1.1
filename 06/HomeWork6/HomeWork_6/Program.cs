using System;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            var num = 0;
            var num1 = 0;
            var i = 0;
           
            Console.WriteLine(" Enter a positive positive natural number not exceeding 2 billion: ");
                num = int.Parse(Console.ReadLine());

                while (true)
                    {

                    if (num < 0)
                    {
                        Console.WriteLine("Invalid value entered! Try again.");
                        num = int.Parse(Console.ReadLine());
                        continue;    

                    }

                    if (num > 2000000)
                    {
                        Console.WriteLine("Invalid value entered! Try again.");
                        num = int.Parse(Console.ReadLine());
                        continue;
                    }

                    num1 = num % 10;

                    if ((num1 % 2) == 0)
                    {
                        Console.WriteLine($"Even number:{num1} ");
                        i++;
                    }

                    num = num / 10;

                    if (num == 0)
                    {
                        Console.WriteLine($"Number of even numbers: { i}");
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Try typing again");
                
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Try typing again");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Try typing again");
            }

            Console.ReadKey();

            



        }
    }
}
