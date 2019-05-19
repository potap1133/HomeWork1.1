using System;

namespace L05_C00_enum_methods
{
	class Program
	{
		[Flags]
		enum ColorPallet : short
		{
			None = 0x0,
			Black = 0x1,
			Blue = 0x1 << 1,
			Cyan = 0x1 << 2,
			Grey = 0x1 << 3,
			Green = 0x1 << 4,
			Magenta = 0x1 << 5,
			Red = 0x1 << 6,
			White = 0x1 << 7,
			Yellow = 0x1 << 8,
		}

		static void Main(string[] args)
		{
			var colors = GetColors();
			Display("Available colors", colors);

			var favoriteColors = GetFavoriteColors();
			Display("Favorite colors for user", favoriteColors);

			var remainingColors = colors ^ favoriteColors;
			Display("Remaining colors", remainingColors);

			Console.ReadKey();
		}

		static ColorPallet GetFavoriteColors()
		{
			var colors = ColorPallet.None;

			for (var i = 0; i < 4; i++)
			{
				var color = ReadColor(i);
				colors |= color;
			}

			return colors;
		}

		static ColorPallet ReadColor(int number)
		{
			while(true)
			{
				Write($"Please, enter your favorite color, number {number}: ", ConsoleColor.White);

				var input = Console.ReadLine();
				if (Enum.TryParse(typeof(ColorPallet), input, out var result) && (ColorPallet)result > 0)
				{
					return (ColorPallet)result;
				}

				WriteLine("Wrong value for color!", ConsoleColor.Red);
			}
		}

		static ColorPallet GetColors()
		{
			var result = ColorPallet.None;
			var values = (ColorPallet[]) Enum.GetValues(typeof(ColorPallet));

			for (var i = 0; i < values.Length; i++)
			{
				result = result | values[i];
			}

			return result;
		}

		static void Display(string header, ColorPallet color)
		{
			WriteLine(header, ConsoleColor.Green);

			for (int shift = 0, order = 0; shift < sizeof(short) * 8; shift++)
			{
				var value = (short) (0x1 << shift);

				if (((short) color & value) == value)
				{
					Write((++order).ToString(), ConsoleColor.Yellow);
					Write(" has byte position", ConsoleColor.White);
					Write($" {shift}", ConsoleColor.Red);
					Write(" and byte binary value", ConsoleColor.White);
					Write($" {Convert.ToString(value, 2).PadLeft(16, '0')}", ConsoleColor.Red);
					Write(" and pallet color is", ConsoleColor.White);
					WriteLine($" {(ColorPallet) value}", ConsoleColor.Red);
				}
			}
		}

		static void Write(string message, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.Write(message);
			Console.ForegroundColor = restoreColor;
		}

		static void WriteLine(string message, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ForegroundColor = restoreColor;
		}
	}
}