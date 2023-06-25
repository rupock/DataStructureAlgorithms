//using System;

using System.Data;

namespace StackDataStructureAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			int option = 0;
			Utilities.Manu();
			StackArray stackArray= new StackArray();
			QueueArray queueaArray = new QueueArray(10);
		
			
		
			while(option!=4)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("0.Stack");
				Console.WriteLine("1.Clear screen");
				Console.WriteLine("2.Queue");
				Console.WriteLine("3.Exit");
				try
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"\nPlease select the option:");
					option = Utilities.GetNumberFromInput();
				}
				catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(ex.Message);
				}

			
				
				option++;
				

				switch (option)
				{ 
					case 1:
						stackArray.Main();
						break;
					case 2:

						Utilities.ClearScreen();
						break;
					case 3:
						queueaArray.Main();
															;
						break;
					case 4:
                        Console.WriteLine("exit");
                        break;
					default:
						Console.WriteLine("wrong choice, please try again! ");
					 break;
				}
			}
		    

            Console.WriteLine(Utilities.EndOfProgram());
        }
	}
}

