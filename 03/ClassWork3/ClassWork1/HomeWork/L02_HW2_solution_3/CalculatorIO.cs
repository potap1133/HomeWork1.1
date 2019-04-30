using System;
using System.Globalization;
using System.Linq;

namespace L02_HW2_solution_3
{
	/// <summary>
	/// Maintenance input/output class for the calculator.
	/// </summary>
	public class CalculatorIO
	{
		private readonly ConsoleWriter _writer;

		/// <summary>
		/// Initializes a new instance of the <see cref="CalculatorIO"/> class.
		/// </summary>
		/// <param name="consoleWriter">The console writer.</param>
		public CalculatorIO(ConsoleWriter consoleWriter)
		{
			_writer = consoleWriter;
		}

		/// <summary>
		/// Writes out the title for the Calculator application.
		/// </summary>
		/// <param name="operators"></param>
		public void WriteTitle(char[] operators)
		{
			_writer.WriteWithYellow("Calculator\n");
			_writer.Write(
			  $"  Use operands range: {double.MinValue}–{double.MaxValue}\n" +
			  $"  Use \"{CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator}\" as a fractional part separator\n" +
			  "  Use one of the following operators: ");
			_writer.WriteWithYellow(string.Join(" ", operators) + "\n\n");
		}

		/// <summary>
		/// Writes out the result of the calculation with two operands.
		/// </summary>
		/// <param name="first">Operand #1</param>
		/// <param name="second">Operand #2</param>
		/// <param name="operator">Operator</param>
		/// <param name="result">Calculation result</param>
		public void WriteResult(
			double first, 
			double second, 
			char @operator, 
			double result)
		{
			Console.Write($"\n{first} {@operator} {second} = ");
			_writer.WriteWithGreen($"{result}\n");
		}

		/// <summary>
		/// Reads the operand from console with repeats.
		/// </summary>
		/// <param name="description">Text to be added to the prompt for entering the operand's value</param>
		/// <returns>The value of the operand</returns>
		public double ReadOperand(string description)
		{
			while (true)
			{
				_writer.Write($"Enter the {description} operand: ");
				if (double.TryParse(Console.ReadLine(), out var operand))
				{
					return operand;
				}
				_writer.WriteWithRed("Wrong value! ");
			}
		}

		/// <summary>
		/// Reads the operator sign for the calculation with repeats.
		/// The list of operator signs is limited by the _operators filed.
		/// </summary>
		/// <param name="operators">The array of operator signs supported by Calculator.</param>
		/// <returns>Single-char variable contains the sign of the operation</returns>
		public char ReadOperator(char[] operators)
		{
			while (true)
			{
				_writer.Write("Enter the operator : ");
				var input = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(input) && operators.Contains(input[0]))
				{
					return input[0];
				}
				_writer.WriteWithRed("Wrong value! ");
			}
		}
	}
}
