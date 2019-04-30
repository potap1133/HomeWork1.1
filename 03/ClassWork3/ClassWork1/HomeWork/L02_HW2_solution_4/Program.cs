using System;
using System.Globalization;

namespace L02_HW2_solution_4
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var cultureInfo = ReadCultureInfo(args);
			var writer = new ConsoleWriter(cultureInfo);
			var calculator = new Calculator(writer);
			calculator.Execute();
		}

		private static CultureInfo ReadCultureInfo(string[] args)
		{
			var cultureInfo = CultureInfo.InvariantCulture;

			if (args?.Length > 0)
			{
				try
				{
					cultureInfo = CultureInfo.CreateSpecificCulture(args[0]);
				}
				catch (Exception exception)
				{
					Console.WriteLine(exception.ToString());
				}
			}

			return cultureInfo;
		}
	}
}
