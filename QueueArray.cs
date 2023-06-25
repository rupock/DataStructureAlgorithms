//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using System.Drawing;
//using System.Globalization;

namespace StackDataStructureAlgorithms
{
    public class QueueArray
    {
		private int[] elements;
		private int _size;
		int head,tail;
        public QueueArray(int size)
        {
         elements = new int[size];	
			this._size = size;
			head = -1;
			tail = -1;
        }		

		public void Main()
		{
			QueueArray queue=new QueueArray(elements.Length);	
			queue.head = -1;
			queue.tail = -1;
			int choice = 0;
			int value = 0;
				

			while (choice != 4)
			{
				Utilities.Manu();
				Console.WriteLine("\n** Queue *");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("1. EnQueue");
				Console.WriteLine("2. DeQueue");
				Console.WriteLine("3. Show");
				Console.WriteLine("4. Exit");
				Console.WriteLine("5. Clear Screen");
				Console.ForegroundColor = ConsoleColor.Red;
			
				try
				{
					Console.WriteLine($"Please enter your choice:");
					// choice = Convert.ToInt32(Console.ReadLine());
					choice = Utilities.GetNumberFromInput();
				}
				catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(ex.Message);
				}	
				
				switch (choice)
				{
					case 1:
						try
						{
							queue.EnQueue(value);
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
						finally
						{
							Utilities.ClearScreen();
						}
						break;
					case 2:
						//Console.WriteLine("You choose to remove from Front of the Queue");
						try
						{
							queue.DeQueue(value);
						}
						catch (Exception ex)
						{

							Console.WriteLine(ex.Message);
						}
						finally
						{
							queue.Show();
                            Console.WriteLine($"value remove from the front of the Queue");
                            //Utilities.ClearScreen();
                        }
						break;
					case 3:
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("You choose to dispaly Queue! ");
						try
						{
							queue.Show();	
						}
						catch (Exception ex)
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine(ex.Message);
							Console.WriteLine("You need to restart the program, Queue is full");
						}

						break;

					case 4:
						Console.WriteLine("Existing......");
						break;
					case 5:
						Utilities.ClearScreen();
						break;
					default:
						Console.WriteLine("wrong choice, please try again! ");
						break;
				};
			}


		}
		public void EnQueue(int value)
		{ 
		Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"Enter a value for queue:");
			//     int value = Convert.ToInt32(Console.ReadLine());
			value = Utilities.GetNumberFromInput();

			if (tail == _size - 1)
			{
				Console.WriteLine("\nOverFlow,Queue is full");
			}
			else
			{
				
				if (head == -1)
					head = 0;
				tail++;
				var result = elements[tail] = value;
				Console.WriteLine($"Value inserted in front of the Queue:{result} Insertion was successfull");
			}

		}

		public void DeQueue(int value){
			value = elements[head];
			if(head>=tail)
			{
				head = -1;
				tail = -1;
			}
			else
			{
				head++;	
			}
			return;
		}
		private void Show()
		{
            
            if (tail == -1)
			{
				Console.WriteLine("Queue is empty:");
			}
			else
			{
				Console.WriteLine("Value  Index");
			}
			for (int i = head; i<= tail; i++)
			{

				Console.WriteLine(elements[i]+$"       {i}");
			}
			Console.WriteLine("------------------");

		}



	}
}

