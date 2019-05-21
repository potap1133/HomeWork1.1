using System;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double num1 = 0;
            short num2;

            Console.WriteLine(" Enter a positive positive natural number not exceeding 2 billion: ");

            do
            {
                try
                {
                    num = double.Parse(Console.ReadLine());

                    num1 = num % 10;                    
                    num2 =(short)(num1 % 2);
                    num1 = (int)(num1 / 10);


                    if (num2 == 0)
                    {
                        Console.WriteLine(num1);
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine();
                }

            } while (true);
            




        }
    }
}
