using System;
using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineQueue
    {
        private Queue queue = new Queue();

        public int Count { get { return queue.Count; } }

        public void AddToQueue()
        {
            bool isAdding = true;
            Console.WriteLine("-- Queue Mode --");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Q":
                        isAdding = false;
                        break;
                    case "-":
                        RemoveFromQueue();
                        return;
                    default:
                        queue.Enqueue(input);
                        Console.WriteLine($"{input} added to the queue!");
                        break;
                }

            } while (isAdding);
        }

        public void RemoveFromQueue()
        {
            bool isRemoving = true;
            Console.WriteLine("-- Dequeue Mode --");
            Console.WriteLine("-- Type 'Next' to dequeue --");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Q":
                        isRemoving = false;
                        break;
                    case "+":
                        AddToQueue();
                        return;
                    case "Next":
                        Console.WriteLine(LeaveQueue());
                        break;
                    default:
                        Console.WriteLine("Unknown Command");
                        break;
                }

            } while (isRemoving);
        }

        internal string LeaveQueue()
        {
            if (Count > 0) return $"{queue.Dequeue()} gets expedited and leaves the line.";
            else return $"No one in queue";
        }
    }
}