using System;

namespace MultiFactory
{
    class Candy 
    {
        string Flavour;
        int Amount;

        public Candy(){
            Console.WriteLine("What flavour do you want the candy?");
            Flavour = Console.ReadLine();
            Console.WriteLine("How many pieces do you want?");
            Amount = Convert.ToInt16(Console.ReadLine());
        } 
    }
}
