using System;

namespace L06_C04_do_while_break_SW
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
				if (str == "exit")
				{
					break;
				}
			}
			while (true);

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
