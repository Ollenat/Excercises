using System;

namespace brakTillInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett bråktal - nej för man kan tydligen inte skriva in doubles genom consolen...>:(");

            //double tal = Convert.ToDouble(Console.ReadLine());
            double tal = 9.0;
            
            int heltal = (int)(tal);

            int tiondel = (int)(tal*10) - (heltal * 10);

            //Console.WriteLine(Convert.ToString(tiondel));
            if (tiondel < 5)
            {
                Console.WriteLine(heltal);
            }
            else
            {
                Console.WriteLine(heltal + 1);  
            }
        }
    }
}
