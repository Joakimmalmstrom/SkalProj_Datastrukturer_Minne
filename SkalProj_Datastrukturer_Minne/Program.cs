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
                    + "\n4. CheckParanthesis"
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
            bool quit = false;

            List<string> theList = new List<string>();
            Console.WriteLine("Add a name by typing '+' then the name");
            Console.WriteLine("Remove a name by typing '-' then the name");
            Console.WriteLine("Type '0' to return to Menu");


            do
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);

                        // Count && Capacity of the List
                        Console.WriteLine($"List Capacity: {theList.Capacity}");
                        Console.WriteLine($"List Count: {theList.Count}");
                        break;

                    case '-':
                        var name = theList
                            .Where(n => n == value);

                        if (theList.Remove(name.FirstOrDefault()))
                        {
                            Console.WriteLine($"{value} removed from the list");
                        }
                        else
                        {
                            Console.WriteLine($"{value} was not in the list");
                        }

                        // Count && Capacity of the List
                        Console.WriteLine($"List Capacity: {theList.Capacity}");
                        Console.WriteLine($"List Count: {theList.Count}");

                        break;

                    case '0':
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
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        myQueue.Enqueue(value);

                        Console.WriteLine($"{value} stands in line.");
                        break;

                    case '-':
                        if (myQueue.Count > 0)
                        {
                            Console.WriteLine($"{myQueue.Dequeue()} gets expedited and leaves the line.");
                        }
                        else
                        {
                            Console.WriteLine("The line is currently empty");
                        }
                        break;

                    case '0':
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
                char nav = input[0];
                char[] value = input.Substring(1).ToCharArray();

                switch (nav)
                {
                    case '+':
                        ReverseText(value);
                        break;

                    case '0':
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
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
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

                    case '0':
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
    }
}


