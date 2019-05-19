using System;

namespace L06_C16_foreach_encryption
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter the string for encryption: ");
			var encryptionKey = 1;
			var line = Console.ReadLine();

			foreach (var letter in line)
			{
				Console.Write((char)(letter + encryptionKey));
			}

			Console.WriteLine();

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}