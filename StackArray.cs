//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace StackDataStructureAlgorithms
{
    public class StackArray
    {
        int top;
        int size = 10;
        int i;
        int[] arr = new int[5];


        public void main()
        {
            StackArray st = new StackArray();
            st.top = -1;
            int choice = 0;



            while (choice != 4)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("------MANU--------");
                Console.ResetColor();
                Console.WriteLine("\n** STACK *");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");

                Console.WriteLine("3. Show");

                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Clear Screen");
                Console.ForegroundColor = ConsoleColor.Red;
                try
                {
                    Console.WriteLine($"Please enter your choice:");
                    //  choice = Convert.ToInt32(Console.ReadLine());
                    choice = Utilities.GetNumberFromInput();
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ex.Message);
                }

             
                Console.ResetColor();
                switch (choice)
                {
                    case 1:
                        try
                        {
                            st.Push();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            ClearScreen();
                        }
                        break;
                    case 2:
                        Console.WriteLine("You choose to remove from top of the stack");
                        st.Pop();
                        break;
                    case 3:
                        Console.WriteLine("You choose to dispaly stack! ");
                        try
                        {
                            st.Show();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("You need to restart the program, stack is full");
                        }
                       

                        break;
                       
                    case 4:
                        Console.WriteLine("Existing......");
                        break;
                    case 5:
                        st.ClearScreen();
                        break;
                    default:
                        Console.WriteLine("wrong choice, please try again! ");
                        break;
                };



            }


        }

        private void ClearScreen()
        {
            Console.Clear();
        }

        private Boolean Push()

        {
            Console.WriteLine($"Enter a value for stack:");
            //     int value = Convert.ToInt32(Console.ReadLine());
            int value = Utilities.GetNumberFromInput();


            if (top == size - 1)
            {
                Console.WriteLine("Stack overflow");
                return false;
            }
            else
            {
                top++;
                var result = arr[top] = value;
                Console.WriteLine($"Value inserted at top of the stack:{result}");
            }

            return true;
        }

        private Boolean Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stack Underflow");
                return false;
            }
            else
            {
                var result = arr[top--];
                Console.WriteLine($"Value Removed from the top of stack:{result}");
            }
            return true;
        }

        private void Show()
        {
            
            if (top == -1)
            {
                Console.WriteLine("Stack is empty:");
            }
            else
            {
                Console.WriteLine("Stack has value:");
            }
            for (i = top; i >= 0; i--)
            {

                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("------------------");

        }
    }
}
