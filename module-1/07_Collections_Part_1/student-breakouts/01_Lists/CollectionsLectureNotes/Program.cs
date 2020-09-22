using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Create two lists of integers
            List<int> listType1 = new List<int>();
            List<int> listType2 = new List<int>();


            // Create list of strings
            List<string> listTypeStrings = new List<string>();
            // Write these variables to the console

            // Discuss: What did you see on the console? Is that what you expected?
            
            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////

            // Check if the first list you created is equal to the second list
            // If they are equal, write "They are the same" to the console.
            // If they are not equal, write "They are not the same" to the console.
            // Discuss: Why did you get that result?
            if (listType1 == listType2)
            {
                Console.WriteLine("They are the same");

            }
            else
            {
                Console.WriteLine("They are not the same");
            }

            // Assign the first integer list to the second integer list
            listType1 = listType2;
                if (listType1 == listType2)
            {
                Console.WriteLine("They are the same");

            }
            else
            {
                Console.WriteLine("They are not the same");
            }

            // Check if the first list you created is equal to the second list
            // If they are equal, write "They are the same" to the console.
            // If they are not equal, write "They are not the same" to the console.
            // Discuss: Why did you get that result?


            /////////////////
            // ADDING ITEMS
            /////////////////

            // Add three numbers to one of the integer lists
            listType1.Add(3);
            listType1.Add(8);
            listType1.Add(42);
            // Add four words to the list of strings
            listTypeStrings.AddRange(new string[] { "blue", "green", "yellow", "green" });

            //////////////////
            // ACCESSING BY INDEX
            //////////////////
            // Use a for loop to access each element by its index
            // Write each element to the console. 
            // Do this for both the integer list and the string list.
            for(int i = 0; i<listTypeStrings.Count; i++)
            {
                Console.WriteLine(listTypeStrings[i]);
            }

            foreach(string word in listTypeStrings)
            {
                Console.WriteLine("From Foreach: " + word);
            }


            Console.ReadLine();

        }
    }
}
