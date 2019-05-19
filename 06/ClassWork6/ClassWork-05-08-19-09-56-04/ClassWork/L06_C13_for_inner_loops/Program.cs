using System;

namespace L06_C13_for_inner_loops
{
	class Program
	{
		static void Main()
		{
			for (var x = 1; x <= 2; x++)
			{
				var isBreakFromExternalLoopRequired = false;

				for (var y = 1; y <= 3; y++)
				{
					Console.WriteLine($"{x} * {y} = {x * y}");

					// potential reason to do break from both loops
					if (y == 3) 
					{
						isBreakFromExternalLoopRequired = true;
						break;
					}
				}

				if(isBreakFromExternalLoopRequired)
				{
					break;
				}

				Console.WriteLine("The end external loop cycle");
			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}