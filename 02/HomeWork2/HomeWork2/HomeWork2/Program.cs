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
            Console.WriteLine("Enter the number a ");
            var num = Console.ReadLine();
            double first = double.Parse(num);
            Console.WriteLine();

            Console.WriteLine("Enter the number b ");
            var snum = Console.ReadLine();
            double second = double.Parse(snum);
            Console.WriteLine();

            var result1 = first + second;
            var result2 = first - second;
            var result3 = first * second;
            Console.WriteLine();
            Console.WriteLine("Plus\tMinus\tMultiplication");
            Console.WriteLine("{0}\t{1}\t{2}", result1, result2, result3);
            Console.WriteLine();
        }

    }
}
