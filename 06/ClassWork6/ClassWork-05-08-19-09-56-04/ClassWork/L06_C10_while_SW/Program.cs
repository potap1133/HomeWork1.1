using System;

namespace L06_C10_while_SW
{
	class Program
	{
		static void Main()
		{
			var numbers = new int[]{ 1, 2, 3, 4, 5, 6 };
			var sum = 0;
			var counter = 0;

			while (counter < numbers.Length)
			{
				var number = numbers[counter];
				sum += number;

				Console.WriteLine($"Current iteration is {counter}, sum is {sum}");

				++counter;
			}

			Console.WriteLine($"Total sum is {sum}");
			Console.ReadKey();
		}
	}
}
