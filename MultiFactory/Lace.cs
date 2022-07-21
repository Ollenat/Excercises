using System;

namespace MultiFactory
{
    class Lace 
    {   
        double Length;
        string Colour;

        public Lace(){
            Console.WriteLine("What colour do you want your lace?");
            Colour = Console.ReadLine();
            Console.WriteLine("How long do you want the lace to be? (cm)");
            Length = Convert.ToDouble(Console.ReadLine());
        }
    }
}
