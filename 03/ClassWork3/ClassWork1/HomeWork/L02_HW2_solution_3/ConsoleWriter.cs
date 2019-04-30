using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace L02_HW2_solution_3
{
	/// <summary>
	/// Implements the Console wrapper for convenient work with colors in the console.
	/// Initializes console to work with Unicode encoding.
	/// </summary>
	public class ConsoleWriter
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConsoleWriter"/> class.
		/// </summary>
		public ConsoleWriter()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
		}

		/// <summary>
		/// Transparent wrapper for Console.Write method.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void Write(string text) => Console.Write(text);

		/// <summary>
		/// Transparent wrapper for Console.WriteLine method.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteLine(string text) => Console.WriteLine(text);

		/// <summary>
		/// Wrapper for Console.Write method with red font color.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteWithRed(string text) => WriteWithColor(text, ConsoleColor.Red);

		/// <summary>
		/// Wrapper for Console.Write method with green font color.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteWithGreen(string text) => WriteWithColor(text, ConsoleColor.Green);

		/// <summary>
		/// Wrapper for Console.Write method with yellow font color.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteWithYellow(string text) => WriteWithColor(text, ConsoleColor.Yellow);

		private void WriteWithColor(string text, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.Write(text);
			Console.ForegroundColor = restoreColor;
		}
	}
}
