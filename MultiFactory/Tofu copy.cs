using System;

namespace MultiFactory
{
    class Tofu 
    {
        double Volume;
        string Seasoning;

        public Tofu(){
            Console.WriteLine("How much tofu do you want? (Litres)");
            Volume = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What seasoning do you want?");
            Seasoning = Console.ReadLine();
        }
    }
}
