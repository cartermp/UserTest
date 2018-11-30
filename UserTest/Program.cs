using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp68
{
    class Program
    {
        static void PrintStats(List<Fruit> fruit, List<Person> people)
        {
            // Print out the values of properties in fruit and people (such as Name)
        }

        static List<Person> GetPeople(string json)
        {
            // Use JSON.NET to convert to JSON string into a list of people:
            //
            // JsonConvert.DeserializeObject<List<Person>>)(json)
            throw new NotImplementedException();
        }

        static List<Fruit> GetFruit(string json)
        {
            // Use JSON.NET to convert the JSON string into a list of fruits:
            //
            // JsonConvert.DeserializeObject<List<Fruit>>)(json)
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

            // 1. Read the JSON files into JSON strings using ReadFile



            // 2. Convert the JSON strings into lists of fruit and people with GetFruit and GetPeople


            // 3. Call PrintStats with the list of fruit and list of people



            Console.ReadKey();
        }
    }
}
