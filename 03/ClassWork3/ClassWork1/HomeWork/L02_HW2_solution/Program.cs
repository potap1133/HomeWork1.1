using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace L02_HW2_solution
{
	internal class Program
	{
		private static void Main()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			var defaultColor = Console.ForegroundColor;
			var operators = new[] { '+', '-', '*', '/', '%', '^' };

			Console.WriteLine("Calculator");
			Console.WriteLine($"Operands range: {double.MinValue}–{double.MaxValue}");
			Console.WriteLine($"Use \"{CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator}\""
							  + " as a fractional part separator");
			Console.WriteLine($"Use one of the following operators: {string.Join(" ", operators)}");
			Console.WriteLine();

			double firstOperand;
			while (true)
			{
				Console.Write("Enter the 1st operand: ");

				if (double.TryParse(Console.ReadLine(), out firstOperand))
				{
					break;
				}

				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Wrong value! ");
				Console.ForegroundColor = defaultColor;
			}

			double secondOperand;
			while (true)
			{
				Console.Write("Enter the 2nd operand: ");
				if (double.TryParse(Console.ReadLine(), out secondOperand))
				{
					break;
				}

				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Wrong value! ");
				Console.ForegroundColor = defaultColor;
			}

			char @operator;
			while (true)
			{
				Console.Write("Enter the operator : ");
				var input = Console.ReadLine();

				if (!string.IsNullOrWhiteSpace(input) && operators.Contains(input[0]))
				{
					@operator = input[0];
					break;
				}

				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Wrong value! ");
				Console.ForegroundColor = defaultColor;
			}

			double result;
			switch (@operator)
			{
				case '+':
					result = firstOperand + secondOperand;
					break;
				case '-':
					result = firstOperand - secondOperand;
					break;
				case '*':
					result = firstOperand * secondOperand;
					break;
				case '/':
					result = firstOperand / secondOperand;
					break;
				case '%':
					result = firstOperand % secondOperand;
					break;
				default:
					result = Math.Pow(firstOperand, secondOperand);
					break;
			}

			Console.Write($"\n{firstOperand} {@operator} {secondOperand} = ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"{result}");
			Console.ForegroundColor = defaultColor;
			Console.ReadKey();
		}
	}
}
