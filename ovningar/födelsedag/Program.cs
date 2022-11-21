using System;

namespace födelsedag
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] months = new string[]
            {"Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December"};

            Console.WriteLine("När fyller då år?");
            Console.WriteLine("Vilken månad?");
            for (int i = 0; i < 12; i++)          {
                Console.WriteLine($"{i + 1} - {months[i]} ");
            }

            int MonthIndex = Convert.ToInt16(Console.ReadLine()); // Nummer på månad (Födelsedag)

            Console.WriteLine("Och datum?");

            int day = Convert.ToInt16(Console.ReadLine()); // Nummer på dag / datum (Födelsedag)


            int today = DateTime.Today.Day; // Nummer på dag / datum (idag)
            int month = DateTime.Today.Month; // Nummer på månad (idag)

            //Räkna ut hur många dagar in på året du fyller år

            int dagarIn = 0;
            for (int i = 0; i < MonthIndex; i++)
            {
               dagarIn += DateTime.DaysInMonth(DateTime.Today.Year, i + 1);
            }
            dagarIn -= DateTime.DaysInMonth(DateTime.Today.Year, MonthIndex);
            dagarIn += day;

            int dagarInIdag = 0;
            for (int i = 0; i < month; i++)
            {
               dagarInIdag += DateTime.DaysInMonth(DateTime.Today.Year, i + 1);
            }
            dagarInIdag -= DateTime.DaysInMonth(DateTime.Today.Year, month);
            dagarInIdag += today;


            int dagarKvar = dagarIn - dagarInIdag; 
            if (dagarInIdag > dagarIn)
            {
                dagarKvar = 365 + dagarKvar;
            }
            else if (dagarKvar == 0)
            {
                Console.WriteLine("Grattis på födelsedagen!");
                return;
            }

            Console.WriteLine($"Din födelsedag är {dagarIn} dagar in på året,\nIdag är det den {dagarInIdag} dagen på året,\nDet är {dagarKvar} till du fyller år!");

        }
    }
}
