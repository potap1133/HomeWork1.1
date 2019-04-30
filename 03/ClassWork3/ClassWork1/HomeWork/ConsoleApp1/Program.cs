using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			object[] names = new object[]
			{
				"A",
				1,
				3.14,
				5m
			};
			object obj = names[0];
			string str = (string)obj;

			int[] ints = new int[]
			{
				1,
				2,
				3,
				4
			};
			names[0] = "A";
			names[1] = "B";
			names[2] = "C";
			names[3] = "D";
			names[4] = "E";

			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine($"Enter {i} value of array, please");
				names[i] = Console.ReadLine();
			}

			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine($"Value {i} of array, is {names[i]}");
			}

			Console.WriteLine("Completed.");
			Console.ReadKey();
		}
	}
}
