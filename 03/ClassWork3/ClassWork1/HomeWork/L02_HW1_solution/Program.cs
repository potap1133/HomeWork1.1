using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Enter the first integer value: ");
		var first = int.Parse(Console.ReadLine());

		Console.WriteLine();
		Console.Write("Enter the second integer value: ");
		var second = int.Parse(Console.ReadLine());

		Console.WriteLine($"The sum is {first + second}");
		Console.WriteLine($"The difference is {first - second}");
		Console.WriteLine($"The product is {first * second}");
	}
}
