using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    
    class Program {
        [Flags]
        enum packets
        {
            TwentyLiters = 0x1,
            FiveLiters = 0x1 << 1,
            OneLiters = 0x1 << 2

        }
          
        static void Main(string[] args)
        {
           
            Console.WriteLine(" How much juice (in liters) do you need to pack? :");
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine();

            var TwentyLiters = num / 20;
            if (TwentyLiters > 0)
            {
                Console.WriteLine($"20L :  {Math.Floor(TwentyLiters)}");
            }
                        
            var FiveLiters = num % 20;
            if (FiveLiters > 0)
            {
                Console.WriteLine($" 5L : {Math.Floor(FiveLiters / 5)}");
            }

            var OneLiters = FiveLiters % 5;
            if (OneLiters > 0)
            {
                Console.WriteLine($" 1L : {OneLiters}");
            }
            else if (OneLiters < 0)
            {
                Console.WriteLine($" 1L : {1}");
            }
            
            Console.ReadKey();
        }
    }
}
