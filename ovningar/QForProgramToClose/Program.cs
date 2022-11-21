using System;

namespace QForProgramToClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new printer();
            printer.print();
        }
    }
    class printer
    {
        public int Factor = 1;
        public void print(){
            for (int i = 0; i < Factor; i++)
            {
                Console.WriteLine("Och sen då?");
            }
            var inputKey = Console.ReadLine();
            if (inputKey == "Q")
            {
                Factor *= 2;
                Console.WriteLine("=========================================================");
                this.print();
            }else
            {
                return;
            }
        }
    }
}
