using System;

class Program
{
	static void Main()
	{
		// declaring the size of the array
		var names = new string[4];

		// storing items at index positions
		names[0] = "Andrey";
		names[1] = "Maria";
		names[2] = "Alexander";
		names[3] = "Eugenia";

		// looping through the array
		for (var i = 0; i < names.Length; i++)
		{
			Console.WriteLine(names[i]); // read the item at this index
		}
	}
}