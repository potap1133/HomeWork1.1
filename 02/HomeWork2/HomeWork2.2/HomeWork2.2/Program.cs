using System;

namespace HomeWork2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cnum;
            string num;
            string snam;
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
            cnum = Console.ReadLine();
            switch (cnum)
            {

                case "+":

                    result = First + Second;
                    Console.WriteLine(result);
                    break;

                case "-":

                    result = First - Second;
                    Console.WriteLine(result);

                    break;
                case "*":

                    result = First * Second;
                    Console.WriteLine(result);

                    break;
                case "/":

                    result = First / Second;
                    Console.WriteLine(result);

                    break;
                case "%":

                    result = First % Second;
                    Console.WriteLine(result);

                    break;
                
                /*case "^":

                    result = First ^ Second;
                    Console.WriteLine(result);

                    break;*/
            }

           /*}            

            else if (cnum = - )
            {
                result = First - Second;
                 Console.WriteLine(result);
            }
            
            else if (cnum = * )
            {
                result = First * Second;
                 Console.WriteLine(result);
            }

            else if (cnum = / )
            {
                result = First / Second;
                 Console.WriteLine(result);
            }*/
                                   
            }

        }

      }