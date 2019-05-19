using System;

namespace L06_C05_do_while_continue
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter integer values.");
			Console.WriteLine("When Sum exceeds 100 program will be finished:");

			var sum = 0;
			do
			{
				try
				{
					var i = int.Parse(Console.ReadLine());
					sum = sum + i;
				}
				catch (FormatException)
				{
					Console.WriteLine("You entered wrong value! Please try again:");
					continue;
				}

				sum *= 2;
			} 
			while (sum < 100);

			Console.WriteLine($"The sum is {sum}. Press any key to exit...");
			Console.ReadKey();
		}
	}
}