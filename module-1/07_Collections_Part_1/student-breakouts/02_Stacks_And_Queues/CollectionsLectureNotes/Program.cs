using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {

            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.

            // Create a queue of strings
            Queue<string> dailyTasks = new Queue<string>();
            // Add four tasks to the queue that you do every day
            dailyTasks.Enqueue("Code");
            dailyTasks.Enqueue("Learn about Code");
            dailyTasks.Enqueue("Read about Code");
            dailyTasks.Enqueue("Get confused about Code");


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            // Print each task to the console in the order they were entered (FIFO)
            while (dailyTasks.Count > 0)
            {
                
                Console.WriteLine(dailyTasks.Dequeue());
            }
            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 

            // Create a stack of strings
            Stack<string> breakfastFood = new Stack<string>();
            // Add to the stack four things you might eat for breakfast
            breakfastFood.Push("Eggs");
            breakfastFood.Push("bacon");
            breakfastFood.Push("cereal");
            breakfastFood.Push("shake");

            ////////////////////
            // POPPING THE STACK
            ////////////////////

            // Print each breakfast item to the console in reverse order (LIFO)
            while (breakfastFood.Count > 0)
            {
                string reverseBreakfast = breakfastFood.Pop();
                string nextItem = breakfastFood.Count > 0 ? breakfastFood.Peek(): "All Done";
                if (reverseBreakfast != "Eggs")
                {
                    Console.WriteLine($"For breakfast I had {reverseBreakfast}.");
                    Console.WriteLine($"Next, I'm going to have {nextItem}.");
                }
            }
            Console.ReadLine();
        }
    }
}
