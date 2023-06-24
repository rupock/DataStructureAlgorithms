using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
