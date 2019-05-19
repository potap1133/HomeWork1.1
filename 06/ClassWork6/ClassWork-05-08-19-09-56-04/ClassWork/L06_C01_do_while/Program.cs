using System;

namespace L06_C01_do_while
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter integer values.");
			Console.WriteLine("When Sum exceeds 100 program will be finished:");

			var sum = 0;

			do
			{   // begin of the cycling block
				var i = int.Parse(Console.ReadLine());
				sum += i;
				// sum = sum + i;
			}
			while (sum < 100);

			Console.WriteLine($"The sum is {sum}. Press any key to exit...");
			Console.ReadKey();
		}
	}
}
