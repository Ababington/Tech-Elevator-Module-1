﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> AnimalGroupName;
            AnimalGroupName = new Dictionary<string, string>()
            {
                {"rhino", "Crash"},{"giraffe","Tower"},{"elephant","Herd"},
                {"lion","Pride"},{"crow","Murder"},{"pigeon","Kit"},
                {"flamingo","Pat"},{"deer","Herd"},{"dog","Pack"},
                {"crocodile","Float"}
            };
            string animalString = "unknown";

            if (animalName == null || animalName == "")
            {
                return animalString;
            }
            else

            if (AnimalGroupName.ContainsKey(animalName.ToLower()))
            {
                animalString = AnimalGroupName[animalName.ToLower()];
            }
            return animalString;
        }

            
        
    }
}
