using System;
using System.Collections.Generic;

namespace AnimalList
{
    class Program
    {
        static void Main(string[] args)
        {
            var asker = new AnimalAsker();
            asker.AskAnimals();
            Environment.Exit(0);
        }
    }
}
class AnimalAsker
{
     private int iterations = 5; 

        private List<string> AnimalList = new List<string>();
        public void AskAnimals()
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.Write("Please name an animal: ");

                string animal = Console.ReadLine();
                AnimalList.Add(animal);
            }
            
            Console.WriteLine("You listed these animals:");

            foreach (var Animal in AnimalList)
            {
                Console.Write($"{Animal}, ");
            }
        }
}
