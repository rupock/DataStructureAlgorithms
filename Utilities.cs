﻿
namespace StackDataStructureAlgorithms
{
	public static class Utilities
	{
		public static int GetNumberFromInput()
		{
			while (true)
			{
				string input = Console.ReadLine()!;

				if (int.TryParse(input, out int number))
				{
					return number;
				}

				Console.WriteLine("Invalid input. Please enter a valid number: ");
			}
		}

		public  static void ClearScreen() => Console.Clear();
		public static string EndOfProgram() =>$"You have now exited from the Program";

		public static void Manu()
		{
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("------MANU--------");
			Console.ResetColor();
		}

	}
}
