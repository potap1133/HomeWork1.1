using System;

namespace L06_C02_do_while_SW
{
	class Program
	{
		static void Main()
		{
			string str;
			Console.WriteLine("Enter text string (or \"exit\" to finish):");
			do
			{
				str = Console.ReadLine();
			}
			while (str != "exit");

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
