using System;

namespace L06_C12_for_array
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter 5 integer values:");
			var numbers = new int[5];

			for (int x = 1; x <= 10; x++)
			{
				for (int y = 1; y <= 10; y++)
				{
					Console.WriteLine($"{x} * {y} = {x * y}");
				}
			}

			Console.WriteLine("The entered values are: " + string.Join(", ", numbers));

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}