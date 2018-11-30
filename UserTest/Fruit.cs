using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp68
{
    public class Fruit
    {
        public Fruit(string name, bool hasSeeds)
        {
            Name = name;
            HasSeeds = hasSeeds;
        }

        public string Name { get; set; }

        public bool HasSeeds { get; set; }
    }
}
