using System;

namespace L02_HW2_solution_3
{
	/// <summary>
	/// Describes the Calculator application.
	/// </summary>
	public class Calculator
	{
		private readonly char[] _operators = { '+', '-', '*', '/', '%', '^' };
		private readonly CalculatorIO _io;

		/// <summary>
		/// Initializes a new instance of the <see cref="Calculator"/> class.
		/// </summary>
		/// <param name="consoleWriter">The console writer.</param>
		public Calculator(ConsoleWriter consoleWriter)
		{
			_io = new CalculatorIO(consoleWriter);
		}

		/// <summary>
		/// Runs the calculation.
		/// </summary>
		public void Execute()
		{
			_io.WriteTitle(_operators);

			var firstOperand = _io.ReadOperand("1st");
			var secondOperand = _io.ReadOperand("2nd");
			var @operator = _io.ReadOperator(_operators);
			var result = Calculate(firstOperand, secondOperand, @operator);

			_io.WriteResult(firstOperand, secondOperand, @operator, result);
		}

		private double Calculate(double first, double second, char @operator)
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
				case '^':
					return Math.Pow(first, second);
				default:
					throw new ArgumentOutOfRangeException(nameof(@operator));
			}
		}
	}
}
