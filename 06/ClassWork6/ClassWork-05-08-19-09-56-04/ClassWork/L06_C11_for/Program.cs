using System;

namespace L06_C11_for
{
	class Program
	{
		static void Main()
		{
			// Common structure
			// for (initializer; condition; iterator)
			//    cycle_body

			for (int i = 0; i < 32; i = (int)Math.Pow(2, i))
			{

			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();

			// Output:
			// 0
			// 1
			// 2
			// 3
			// 4
		}
	}
}