using System;

namespace HomeWork2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cnum;
            string num;
            string snam;
            string inum;
            double First;
            double Second;
            double result;
                                
            Console.WriteLine("Введите число a ");
            num = Console.ReadLine();
            First = double.Parse(num);
            Console.WriteLine();

            Console.WriteLine("Введите число b ");
            snam = Console.ReadLine();
            Second = double.Parse(snam);
            Console.WriteLine();

            Console.WriteLine("Выберите тип операции +,-,*,/,%,^ ");
            inum = Console.ReadLine();
            cnum = bool.Parse(inum);
            Console.WriteLine();
                        
            if (cnum == + ) 
            {
            
                result = First + Second;
                   Console.WriteLine(result);
            }            

            else if (cnum == - )
            {
                result = First - Second;
                 Console.WriteLine(result);
            }
            
            else if (cnum == * )
            {
                result = First * Second;
                 Console.WriteLine(result);
            }

            else if (cnum == / )
            {
                result = First / Second;
                 Console.WriteLine(result);
            }
                       
            }

        }

      }