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
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. Check Paranthesis"
                    + "\n5. Recursive Even & Fibonacci Sequence"
                    + "\n6. Iterative Odd"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
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

                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
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
                Console.WriteLine("Type '+' to add a name to the list");
                Console.WriteLine("Type '-' to remove a name from the list");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Type 'Q' to return to Menu");

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
            bool quit = false;

            Queue myQueue = new Queue();
            Console.WriteLine("Add a person to the queue by typing '+' then the name");
            Console.WriteLine("Remove a person from the queue by typing '-'");
            Console.WriteLine("Type '0' to return to Menu");

            Console.WriteLine("\nICA has opened and the checkout is empty!");

            do
            {
                string input = Console.ReadLine();
                string value = input.Substring(1);

                switch (input)
                {
                    case "+":
                        myQueue.Enqueue(value);

                        Console.WriteLine($"{value} stands in line.");
                        break;

                    case "-":
                        if (myQueue.Count > 0)
                        {
                            Console.WriteLine($"{myQueue.Dequeue()} gets expedited and leaves the line.");
                        }
                        else
                        {
                            Console.WriteLine("The line is currently empty");
                        }
                        break;

                    case "0":
                        quit = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Use '+' or '-'");
                        break;
                }

            } while (!quit);
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
            bool quit = false;

            Console.WriteLine("Type '+' and then the text you want to reverse");
            Console.WriteLine("Type '0' to return to Menu");

            do
            {
                string input = Console.ReadLine();
                char[] value = input.Substring(1).ToCharArray();

                switch (input)
                {
                    case "+":
                        ReverseText(value);
                        break;

                    case "0":
                        quit = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Use '+' to type a name");
                        break;
                }

            } while (!quit);
        }
        private static void ReverseText(char[] text)
        {
            Stack stack = new Stack();

            foreach (var c in text)
            {
                stack.Push(c);
            }

            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()}");
            }

            Console.WriteLine();

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Console.Clear();
            bool quit = false;

            Console.WriteLine("Type '+' and then your text with checked paranthesis");
            Console.WriteLine("Type '0' to return to Menu");

            do
            {
                string input = Console.ReadLine();
                string value = input.Substring(1);

                switch (input)
                {
                    case "+":
                        if (value.Length == 0)
                        {
                            Console.WriteLine($"Type in text");
                        }
                        else if (isWellFormatted(value))
                        {
                            Console.WriteLine($"{value} is well formatted");
                        }
                        else
                        {
                            Console.WriteLine($"{value} is NOT well formatted");
                        }
                        break;

                    case "0":
                        quit = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Use '+' followed by a text of your choice");
                        break;
                }

            } while (!quit);
        }

        public static bool isWellFormatted(string text)
        {
            Stack<char> lastOpen = new Stack<char>();

            foreach (var c in text)
            {
                switch (c)
                {
                    case ')':
                        if (lastOpen.Count == 0 || lastOpen.Pop() != '(') return false;
                        break;
                    case ']':
                        if (lastOpen.Count == 0 || lastOpen.Pop() != '[') return false;
                        break;
                    case '}':
                        if (lastOpen.Count == 0 || lastOpen.Pop() != '{') return false;
                        break;
                    case '>': 
                        if (lastOpen.Count == 0 || lastOpen.Pop() != '<') return false;
                        break;

                    case '(': lastOpen.Push(c); break;
                    case '[': lastOpen.Push(c); break;
                    case '{': lastOpen.Push(c); break;
                    case '<': lastOpen.Push(c); break;
                }
            }
            if (lastOpen.Count == 0) return true;
            else return false;
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


