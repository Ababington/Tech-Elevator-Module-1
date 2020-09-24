using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			//         <key,   value>
			Dictionary<string, string> firstNameToLastName;
			firstNameToLastName = new Dictionary<string, string>();
			Dictionary<int, string> steelerPlayers = new Dictionary<int, string>();
			steelerPlayers[7] = "Ben Rothlessiburger";
			steelerPlayers[19] = "JuJu Smith-Schuster";

			//This sytax: if the key doesnt exist, it will create it
			// if the key does exist, it replaces the value
			//....................<key,       value>
			firstNameToLastName["August"] = "Babington";
			firstNameToLastName["Beth"] = "Campbell";
			firstNameToLastName["Jennifer"] = "O'Brian";

            Console.WriteLine($"August's last name is {firstNameToLastName["August"]}");
			// if the key does exist, it replaces the value
			firstNameToLastName["August"] = "Manilla";
			Console.WriteLine($"August's last name is {firstNameToLastName["August"]}");

			// Another syntax to use is Add
			firstNameToLastName.Add("John", "Cena");
			// With Add, if the key exists....BOOM! (program Crashes)
			// Use ContainsKey to tell if the key exists
			if(!firstNameToLastName.ContainsKey("August"))
            {
				firstNameToLastName.Add("August", "Babington");
            }
			else
            {
				firstNameToLastName.Add("Ben", "Babington");
			}

			Console.WriteLine($"John's last name is {firstNameToLastName["John"]}");
			foreach (string key in firstNameToLastName.Keys)
            {
                Console.WriteLine($"{key}'s last name is {firstNameToLastName[key]}");
            }

			foreach (string value in firstNameToLastName.Values)
            {
                Console.WriteLine("The last name is " + value);
            }

			foreach(KeyValuePair<string,string> kvp in firstNameToLastName)
            {
                Console.WriteLine($"With KeyValuePairs: {kvp.Key} is the key for {kvp.Value}");
            }

			//HashSet Demo
			string[] colors = { "blue", "green", "green", "grey", "yellow", "red" };
			List<string> listColor = new List<string>();
			HashSet<string> hashColors = new HashSet<string>();
			bool hasDuplicates = false;

			for (int i = 0; i < colors.Length; i++)
            {
				listColor.Add(colors[i]);
				hashColors.Add(colors[i]);
				if(!hasDuplicates)
                {
                    Console.WriteLine("Found duplicate"+ colors[i]);
                }

            }
			foreach(string color in listColor)
            {
                Console.WriteLine("From list " + color);

            }
			foreach(string color in hashColors)
            {
                Console.WriteLine("From Hash " + color);
            }
 		}
	}
}
