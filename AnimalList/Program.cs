using System;
using System.Collections.Generic;

namespace AnimalList
{
    class Program
    {
        private int iterations = 5; 

        private List<string> AnimalList = new List<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.Write("Please name an animal: ");

                string animal = Console.ReadLine();
                AnimalList.Add(animal);
            }
            
            foreach (var Animal in AnimalList)
            {
                Console.WriteLine(Animal);
            }
        }
    }
}
