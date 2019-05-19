using System;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine(" Enter a positive positive natural number not exceeding 2 billion: ");
            var num1 = 0;
            do
            {
                try
                {
                    var num = int.Parse(Console.ReadLine());
                    
                    num1 = num % 10;
                                        

                }
                catch
                {
                }

            } while (true);
            if (num1 / 2 == 0)
            {
                Console.WriteLine(num1);
            }




        }
    }
}
