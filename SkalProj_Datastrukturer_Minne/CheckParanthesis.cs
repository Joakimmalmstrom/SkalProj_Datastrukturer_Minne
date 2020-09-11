using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace SkalProj_Datastrukturer_Minne
{
    internal class CheckParanthesis
    {
        private Stack<char> stack = new Stack<char>();
        public int Count { get { return stack.Count; } }

        public void isWellFormatted()
        {
            bool isAdding = true;

            do
            {
                bool isCorrect = true;
                string input = Console.ReadLine();

                if (input == "Q")
                {
                    isAdding = false;
                    return;
                }

                foreach (var c in input)
                {
                    stack.Push(c);

                    switch (c)
                    {
                        case '(':
                            if (stack.Pop() != ')') isCorrect = false;
                            break;
                        case '[':
                            if (stack.Pop() != ']') isCorrect = false;
                            break;
                        case '{':
                            if (stack.Pop() != '}') isCorrect = false;
                            break;
                        case '<':
                            if (stack.Pop() != '>') isCorrect = false;
                            break;
                    }
                }
                if (isCorrect) 
                    Console.WriteLine("Correct Format");
                else 
                    Console.WriteLine("Incorrect Format");
                stack.Clear();

            } while (isAdding);


            //switch (c)
            //{
            //    case '(':
            //        stack.Push(c);
            //        if (stack.Pop() == ')') return true;
            //        break;
            //    case '[':
            //        stack.Push(c);
            //        if (stack.Pop() == ']') return true;
            //        break;
            //    case '{':
            //        stack.Push(c);
            //        if (stack.Pop() == '}') return true;
            //        break;
            //    case '<':
            //        stack.Push(c);
            //        if (stack.Pop() == '>') return true;
            //        break;
            //    default:
            //        return false;
            //}

            //foreach (var c in input)
            //{
            //    switch (c)
            //    {
            //        case ')':
            //            if (stack.Count == 0 || stack.Pop() != '(') return false;
            //            break;
            //        case ']':
            //            if (stack.Count == 0 || stack.Pop() != '[') return false;
            //            break;
            //        case '}':
            //            if (stack.Count == 0 || stack.Pop() != '{') return false;
            //            break;
            //        case '>':
            //            if (stack.Count == 0 || stack.Pop() != '<') return false;
            //            break;

            //        case '(': stack.Push(c); break;
            //        case '[': stack.Push(c); break;
            //        case '{': stack.Push(c); break;
            //        case '<': stack.Push(c); break;
            //    }
            //}
            //if (stack.Count == 0) return true;
            //else return false;
        }
    }
}
