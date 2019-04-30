using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    
    class Program
    { 
    [Flags]
        enum containers: byte
        {
        OneLiters = 0x1,
        TenLiters = 0x1 <<1,
        TwentyLiters = 0x1 << 2
        }

        static void Main(string[] args)
        {

            Console.WriteLine(" How much juice (in liters) do you need to pack? :");
            var num = int.Parse(Console.ReadLine());
            for (int i = 20; i >= 20; i = num - 20)
            {
                var summa = i++;
                Console.WriteLine(summa);
            }
            Console.ReadKey();
        }
    }
}
