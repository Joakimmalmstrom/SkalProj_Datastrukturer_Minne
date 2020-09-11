using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Diagnostics.Contracts;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            // Question 1: Value types are always stored in the stack. Reference Types are stored in the heap.
            // Example: int value = 3; || Allocates memory on the stack
            // Example: Human human = new Human(string name, int age) || Human class is stored on the heap with its parameters. 
            // Objects that's allocated on the stack are only available inside of a method, while Objects on the stack can be accessed from anywhere.
            // Question 2: Value types are int, bool, float etc || Reference Types are classes, interface, delegates etc. Value types are allocated on the stack while Reference types are allocated on the heap.
            // Question 3: In Method ReturnValue2 both x and y share the same property. They come from the same class and y sets MyValue to 4. x inherits MyValue from y when declaring y = x;.

            while (true)
            {
                MainMenuInfo();

                char input = InputCheck();

                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        RecursiveEvenApp();
                        break;
                    case '6':
                        IterativeOddApp();
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        private static void MainMenuInfo()
        {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                + "\n1. Examine a List"
                + "\n2. Examine a Queue"
                + "\n3. Examine a Stack"
                + "\n4. Check Paranthesis"
                + "\n5. Recursive Even & Fibonacci Sequence"
                + "\n6. Iterative Odd"
                + "\n0. Exit the application");
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            // Question 1: When the count is equals to its capacity.
            // Question 2: It doubles the current capacity.
            // Question 3: It only allocates more memory when count exceeds its capacity.
            // Question 4: No it does not. It needs a Trim method to scale down the capacity.
            // Question 5: When you know the number of elements needed.

            Console.Clear();

            ExamineList examine = new ExamineList();
            bool quit = false;

            do
            {
                ExamineListInfo();

                char input = InputCheck();

                switch (input)
                {
                    case '+':
                        Console.WriteLine("Add names to the list");
                        examine.AddToList();

                        Console.Clear();
                        break;
                    case '-':
                        Console.WriteLine("Remove names from the list");
                        examine.RemoveFromList();

                        Console.Clear();
                        break;
                    case 'Q':
                        Console.Clear();
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid command");
                        break;
                }
            } while (!quit);
        }

        private static void ExamineListInfo()
        {
            Console.WriteLine("Type '+' to add a name to the list");
            Console.WriteLine("Type '-' to remove a name from the list");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Type 'Q' to return to Menu");
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Console.Clear();

            ExamineQueue examineQueue = new ExamineQueue();
            bool quit = false;

            do
            {
                ExamineQueueInfo();

                char input = InputCheck();

                switch (input)
                {
                    case '+':
                        examineQueue.AddToQueue();

                        Console.Clear();
                        break;

                    case '-':
                        examineQueue.RemoveFromQueue();

                        Console.Clear();
                        break;

                    case 'Q':
                        quit = true;

                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Use '+' or '-'");
                        break;
                }

            } while (!quit);
        }

        private static char InputCheck()
        {
            char input = ' ';

            try
            {
                input = Console.ReadLine()[0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }

            return input;
        }

        private static void ExamineQueueInfo()
        {
            Console.WriteLine("ICA has opened and the checkout is empty!\n");
            Console.WriteLine("Type '+' to enter add to queue mode");
            Console.WriteLine("Type '-' to enter remove queue mode");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Type 'Q' to return to Menu");
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            // Question 1: Then the first person that gets added to the line is the last one to go. The queue system gets reversed.

            Console.Clear();

            ExamineStack examineStack = new ExamineStack();
            bool quit = false;

            do
            {
                ExamineStackInfo();

                char input = InputCheck();

                switch (input)
                {
                    case '+':
                        examineStack.ReverseText();

                        Console.Clear();
                        break;

                    case 'Q':
                        quit = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Use '+' to type a name");
                        break;
                }

            } while (!quit);
        }

        private static void ExamineStackInfo()
        {
            Console.WriteLine("Type '+' to enter Reverse Text Mode");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Type 'Q' to return to Menu");
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Console.Clear();

            CheckParanthesis checkParanthesis = new CheckParanthesis();
            bool quit = false;

            do
            {
                Console.WriteLine("Type '+' to enter Check Paranthesis Mode");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Type 'Q' to return to Menu");

                char input = InputCheck();

                switch (input)
                {
                    case '+':
                        checkParanthesis.isWellFormatted();

                        Console.Clear();
                        break;

                    case 'Q':
                        quit = true;

                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Use '+' followed by a text of your choice");
                        break;
                }

            } while (!quit);
        }

        public static void RecursiveEvenApp()
        {
            Console.Clear();
            bool quit = false;

            Console.WriteLine("Enter a number");
            Console.WriteLine("Type 'F' for Fibonacci Sequence");
            Console.WriteLine("Type 'R' for Recursive Even Sequence");
            Console.WriteLine("Type 'Q' to exit the application");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "F":
                        Console.WriteLine("Enter a number for fibonacci sequence");
                        int fInput = int.Parse(Console.ReadLine());
                        Console.WriteLine(Fibonacci(fInput));
                        break;
                    case "R":
                        Console.WriteLine("Enter a number for recursive even");
                        int rInput = int.Parse(Console.ReadLine());
                        Console.WriteLine(RecursiveEven(rInput));
                        break;
                    case "Q":
                        quit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Enter a valid command");
                        break;
                }
            } while (!quit);
        }

        public static int RecursiveEven(int n)
        {
            if (n == 0)
            {
                return n;
            }
            return (RecursiveEven(n - 1) + 3);
        }

        public static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        public static void IterativeOddApp()
        {
            Console.Clear();
            bool quit = false;

            Console.WriteLine("Enter a number");
            Console.WriteLine("Type 'Q' to exit the application");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Q":
                        quit = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine((IterativeOdd(int.Parse(input))));
                        break;
                }
            } while (!quit);
        }

        public static int IterativeOdd(int n)
        {
            if (n == 0) return 1;

            int result = 1;

            for (int i = 0; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }
    }
}


