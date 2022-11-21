using System;

namespace plusTva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tal 1");
            string Tal1 = Console.ReadLine();
            Console.WriteLine("Skriv in tal 2");
            string Tal2 = Console.ReadLine();

            double Nummer1  = Convert.ToDouble(Tal1);
            double Nummer2 = Convert.ToDouble(Tal2);

            double summa = Nummer1 + Nummer2;
            Console.WriteLine(Convert.ToString(summa));
            Console.Read();
        }
    }
}
