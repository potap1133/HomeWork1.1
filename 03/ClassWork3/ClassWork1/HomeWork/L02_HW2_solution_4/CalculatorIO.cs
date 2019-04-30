using System;
using System.Globalization;
using System.Linq;
using L02_HW2_solution_4.Properties;

namespace L02_HW2_solution_4
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
			_writer.WriteWithYellow(Resources.ApplicationName + "\n");

			_writer.Write(
			  "  " + Resources.UseRangeHint + "\n", double.MinValue, double.MaxValue);
			_writer.Write(
			  "  " + Resources.UseFractioanlSeparatorHint + "\n",
			  CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
			_writer.Write(
			  "  " + Resources.UseOperatorsHint + " ");

			_writer.WriteWithYellow(string.Join(" ", operators) + "\n\n");
		}

		/// <summary>
		/// Writes out the result of the calculation with two operands.
		/// </summary>
		/// <param name="operand1">Operand #1</param>
		/// <param name="operand2">Operand #2</param>
		/// <param name="mathOperator">Operator</param>
		/// <param name="result">Calculation result</param>
		public void WriteResult(double operand1, double operand2, char mathOperator, double result)
		{
			Console.Write($"\n{operand1} {mathOperator} {operand2} = ");
			_writer.WriteWithGreen($"{result}\n");
		}

		/// <summary>
		/// Reads the operand from console with repeats.
		/// </summary>
		/// <param name="operandDescription">Text to be added to the prompt for entering the operand's value</param>
		/// <returns>The value of the operand</returns>
		public double ReadOperand(string operandDescription)
		{
			while (true)
			{
				_writer.Write(Resources.OperandRequest + " ", operandDescription);
				if (double.TryParse(Console.ReadLine(), out var operand))
				{
					return operand;
				}
				_writer.WriteWithRed(Resources.WrongValue + " ");
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
				_writer.Write(Resources.OperatorRequest + " ");
				var input = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(input) && operators.Contains(input[0]))
				{
					return input[0];
				}
				_writer.WriteWithRed(Resources.WrongValue + " ");
			}
		}
	}
}
