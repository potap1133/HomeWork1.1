using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдите число a ");
            var s = Console.ReadLine();
            double a = double.Parse(s);

            Console.WriteLine("Введите число b ");
            var g = Console.ReadLine();
            double b = double.Parse(g);

                var c = a + b;
                Console.WriteLine();
                Console.WriteLine("Сумма чисел a и b = " + c);
                Console.WriteLine();

                var n = a - b;
                Console.WriteLine("Разница чисел a и b = " + n);
                Console.WriteLine();

                var m = a * b;
                Console.WriteLine("Произведение чисел a и b =" + m);
             Console.WriteLine();

        }

        private static object parse(string p)
        {
            throw new NotImplementedException();
        }

        public static int a { get; set; }

        public static int b { get; set; }
    }
}
