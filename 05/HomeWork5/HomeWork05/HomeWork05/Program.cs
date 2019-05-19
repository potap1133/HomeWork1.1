using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06
{
    class Program
    {
        [Flags]
        enum Colors: short
        {
            None = 0x0,
            Black = 0x1,
            Blue = 0x1 << 1,
            Cyan = 0x1 << 2,
            Grey = 0x1 << 3,
            Green = 0x1 << 4,
            Magenta = 0x1 << 5,
            Red = 0x1 << 6,
            White = 0x1 << 7,
            Yellow = 0x1 << 8,
        }

        static void Main(string[] args)
        {
           /* string[] massColors = new[9] 
            Black [0];
            Blue [1];
            Cyan [2];
                Grey,
                Green,
                Magenta,
                Red,
                White,
                Yellow*/
            


            /*Console.Write("Choose your favorite colors bay: \nBlack, \nBlue, \nCyan, \nGrey, \nGreen, \nMagenta, \nRed, \nWhite, \nYellow"); 
            Console.ReadKey();
            Console.WriteLine("Write your favorite colors : ");*/

            Console.WriteLine("Write your favorite colors 1 : ");
            var num1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Write your favorite colors 2 : ");
            var num2 = short.Parse(Console.ReadLine());

            Console.WriteLine("Write your favorite colors 3 : ");
            var num3 = short.Parse(Console.ReadLine());
            

            Console.WriteLine("Write your favorite colors 4 : ");
            var num4 = short.Parse(Console.ReadLine());

            /*short [] checkFavorite = new[]
            {
                num1,
                num2,
                num3,
                num4
            };
            */
            short MyFavoriteColors = short.(Colors.num1) | Colors.((short)num2) | Colors.((short)num3) | Colors.((short)num4);

            for (var i = 0; i < 16; i++)
            {
                var runColors = 0x1 << i;
                if ((((short)MyFavoriteColors) & runColors) == runColors)
                {
                    Console.WriteLine($"{runColors}");
                }
            }


                      
            

            var favotiteColors = Colors.


            /*Colors i = Colors.Magenta;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Выберите цвет int{i} ");
            }
            Console.ReadKey();*/

        }
    }
}
