using System;
using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineStack
    {
        private Stack stack = new Stack();

        public void ReverseText()
        {
            bool isAdding = true;
            Console.WriteLine("Insert a text to make it in reverse order!");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Q":
                        isAdding = false;
                        break;
                    default:
                        foreach (var c in input)
                        {
                            stack.Push(c);
                        }

                        Console.Write($"Your text in reverse is: ");
                        while (stack.Count != 0)
                        {
                            Console.Write($"{stack.Pop()}");
                        }
                        Console.WriteLine();
                        break;
                }

            } while (isAdding);


        }
    }
}