namespace L02_HW2_solution_3
{
	internal class Program
	{
		private static void Main()
		{
			var writer = new ConsoleWriter();
			var calculator = new Calculator(writer);
			calculator.Execute();
		}
	}
}
