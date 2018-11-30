using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp68
{
    class Program
    {
        static void PrintStats(List<Fruit> fruit, List<Person> people)
        {
            // Print out the values of properties in fruit and people
        }

        static List<Person> GetFruits(string json)
        {
            // Use JSON.NET to convert to JSON string into a list of people
            throw new NotImplementedException();
        }

        static List<Fruit> GetFruit(string json)
        {
            // Use JSON.NET to convert the JSON string into a list of fruits
            throw new NotImplementedException();
        }

        static string ReadFile(string path)
        {
            // Consider using File.ReadAllText
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            var fruitPath = @"..\..\..\fruit.json";
            var peoplePath = @"..\..\..\people.json";

            // 1. Read the JSON files
            // 2. Convert them int fruits and people (using above methods)
            // 3. Call the method to print stats about the fruit and people

            Console.ReadKey();
        }
    }
}
