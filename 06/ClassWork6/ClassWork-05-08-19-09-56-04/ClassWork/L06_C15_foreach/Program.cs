using System;

namespace L06_C15_foreach
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter 5 integer values:");
			var numbers = new int[5] { 1, 2, 3, 4, 5 };

			for(var i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine($"{numbers[i]}^2 = {numbers[i] * numbers[i]}");
			}

			foreach (var number in numbers)
			{
				Console.WriteLine($"{number}^2 = {number * number}");
			}

			var marks = new []
			{
				new int[] {1, 2, 3},
				new int[] {2, 4},
				null
			};

			foreach (var days in marks)
			{
				if (days != null)
				{
					foreach (var day in days)
					{
					}
				}
			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}