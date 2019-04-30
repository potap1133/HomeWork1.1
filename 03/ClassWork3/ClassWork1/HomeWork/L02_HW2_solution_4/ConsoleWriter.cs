using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace L02_HW2_solution_4
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
		/// <param name="cultureInfo">The culture information.</param>
		public ConsoleWriter(CultureInfo cultureInfo)
		{
			Thread.CurrentThread.CurrentCulture = cultureInfo;
			Thread.CurrentThread.CurrentUICulture = cultureInfo;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
		}

		/// <summary>
		/// Transparent wrapper for Console.Write method.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void Write(string text) => Console.Write(text);

		/// <summary>
		/// Transparent wrapper for Console.Write method with params.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		/// <param name="args">Arguments</param>
		public void Write(string text, params object[] args) => Console.Write(text, args);

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
