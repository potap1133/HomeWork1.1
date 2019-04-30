using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace L02_HW2_solution_2
{
	internal class Program
	{
		private static void Main()
		{
			var operators = new [] { '+', '-', '*', '/', '%', '^' };

			InitializeConsole();
			WriteTitle(operators);

			var firstOperand = ReadOperand("1st");
			var secondOperand = ReadOperand("2nd");
			var @operator = ReadOperator(operators);
			var result = Calculate(firstOperand, secondOperand, @operator);

			WriteResult(firstOperand, secondOperand, @operator, result);
		}

		private static void InitializeConsole()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
		}

		private static void WriteTitle(char[] operators)
		{
			WriteWithGreen("Calculator\n");
			Console.WriteLine($"  Use operands range: {double.MinValue}–{double.MaxValue}");
			Console.WriteLine($"  Use \"{CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator}\""
							  + " as a fractional part separator");
			Console.WriteLine($"  Use one of the following operators: {string.Join(" ", operators)}");
			Console.WriteLine();
		}

		private static double ReadOperand(string operandDescription)
		{
			double operand;

			while (true)
			{
				Console.Write($"Enter the {operandDescription} operand: ");
				if (double.TryParse(Console.ReadLine(), out operand))
				{
					break;
				}

				WriteWithRed("Wrong value! ");
			}

			return operand;
		}

		private static char ReadOperator(char[] operators)
		{
			while (true)
			{
				Console.Write("Enter the operator : ");
				var input = Console.ReadLine();

				if (!string.IsNullOrWhiteSpace(input) && operators.Contains(input[0]))
				{
					return input[0];
				}

				WriteWithRed("Wrong value! ");
			}
		}

		private static double Calculate(
			double first, 
			double second, 
			char @operator)
		{
			switch (@operator)
			{
				case '+':
					return first + second;
				case '-':
					return first - second;
				case '*':
					return first * second;
				case '/':
					return first / second;
				case '%':
					return first % second;
				default:
					return Math.Pow(first, second);
			}
		}

		private static void WriteResult(
			double first, 
			double second, 
			char @operator, 
			double result)
		{
			Console.Write($"\n{first} {@operator} {second} = ");
			WriteWithGreen($"{result}\n");
			Console.ReadKey();
		}

		private static void WriteWithColor(string text, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.Write(text);
			Console.ForegroundColor = restoreColor;
		}

		private static void WriteWithRed(string text) => 
			WriteWithColor(text, ConsoleColor.Red);

		private static void WriteWithGreen(string text)
		{
			WriteWithColor(text, ConsoleColor.Green);
		}
	}
}
