using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine("Здравствуйте " + name + "!");
            Thread.Sleep(5000);
            Console.WriteLine("Досвидания " + name + "!");
            Console.ReadKey();
        }
    }

