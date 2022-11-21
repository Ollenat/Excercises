using System;

namespace Rucksack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize
            var MyRucksack = new RucksackC();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Välkommen till ryggsäcken!");

            MyRucksack.Menu();

        }

        
    }

    class RucksackC
    {
        string[] Items = new string[10];

        public void Menu(){

            Console.WriteLine("\n[1] Lägg till ett föremål \n[2] Skriv ut innehållet \n[3] Ta bort ett föremål \n[4] Avsluta");
            Console.Write("Välj: ");
            string Input  = Console.ReadLine();
            Console.WriteLine($"-- {Input}");

            switch (Input)
            {
                case "1": 

                    Console.Write("Föremålets namn: ");
                    this.AddItem(Console.ReadLine());

                    this.Menu();
                    
                    break; 

                case "2":

                    this.OutPutItems();

                    this.Menu();

                    break;

                case "3":

                    Console.WriteLine("Vilket fack vill du ta bort ett föremål ifrån?");
                    this.OutPutItems();
                    this.RemoveItem(Convert.ToInt16(Console.ReadLine()));

                    this.Menu();

                    break;
                case "4":

                    Environment.Exit(0);

                    break;
                
            }
        }

        public string AddItem(string Item) { // Returns the added Items name (string)

            //Iterate rucksack to get empty slot
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] == null)
                {
                    Items[i] = Item;
                    Console.WriteLine($"Du lade till föremålet {Item} i väskan i fack nummer {i + 1}");
                    return Item;
                }
            }
            //If full then error
            Console.WriteLine("Ryggsäcken är full! Ta bort ett föremål för att lägga till ett nytt. Max föremål: (10)");

            return Item;
        }

        public string RemoveItem(int fack){ // Returns the old item name (string)
            //get old item 
            string oldItem = Items[fack - 1];
            //remove old item
            Items[fack - 1] = null;

            Console.WriteLine($"Du tog bort {oldItem} från fack {fack}");

            return oldItem;
        }

        public void OutPutItems(){
            
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] != null)
                {
                    Console.WriteLine($"[{i + 1}] - {Items[i]}");
                }
            }

        }
    }
}
