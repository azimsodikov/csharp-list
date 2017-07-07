using System;
using System.Collections.Generic;
namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> planetList1 = new List<string>(){"Pluton", "Neptun"};
            planetList.AddRange(planetList1);
            planetList.Insert(2, "Earth");
            planetList.Insert(4, "Venus");
            planetList.Add("Pluto");
            string[] output = planetList.GetRange(2, 2).ToArray();
            planetList.RemoveAt(8);
        }
    }
}
