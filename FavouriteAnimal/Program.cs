using System;

namespace FavouriteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var Marcus = new BelugaWhale("Marcus", 15);
            var Miranda = new BelugaWhale("Miranda", 16);
            Marcus.Talk();
            Miranda.Talk();
        }
    }

    class BelugaWhale
    {
        private string Name;
        private int Age;
        private string Noise = "Ahh"; 

        public BelugaWhale(string name, int age){ //This is the constructor where we determine the name and age of the beluga whale.
            Name = name;
            Age = age;
        }

        public void Talk(){ //Here we let the beluga whale tell us how old it is, it's name and what it sounds like.
            Console.WriteLine($"Mitt namn är {Name} och jag är {Age} år gammal. \nJag låter så här: {Noise}");
        }
    }
}
