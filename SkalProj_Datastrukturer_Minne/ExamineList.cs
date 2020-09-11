using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Globalization;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineList
    {
        private List<string> examineList = new List<string>();

        public int Count { get { return examineList.Count; } } 
        public int Capacity { get { return examineList.Capacity; } } 

        public void AddToList()
        {
            bool isAdding = true;
            Console.WriteLine("-- Adding Mode --");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Q":
                        isAdding = false;
                        break;
                    case "-":
                        RemoveFromList();
                        return;
                    default:
                        examineList.Add(input);
                        Console.WriteLine($"{input} added to the list!");
                        DisplayCountCapacity();
                        break;
                }

            } while (isAdding);
        }

        internal void RemoveFromList()
        {
            bool isRemoving = true;
            Console.WriteLine("-- Remove Mode --");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Q":
                        isRemoving = false;
                        break;
                    case "+":
                        AddToList();
                        return;
                    default:
                        Console.WriteLine(RemoveCheck(input));
                        DisplayCountCapacity();
                        break;
                }

            } while (isRemoving);
        }

        internal void DisplayCountCapacity()
        {
            Console.WriteLine($"Count: {Count} -- Capacity: {Capacity}");
        }

        internal string RemoveCheck(string userInput)
        {
            if (examineList.Remove(userInput)) return $"{userInput} removed from the list!";
            else return $"{userInput} was not found in the list!";
        }
    }
}