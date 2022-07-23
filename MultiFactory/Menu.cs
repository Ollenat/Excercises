using System;
using System.Collections.Generic;

namespace MultiFactory
{
    class Menu 
    {
        Orders Orders = new Orders();

        public Menu(){ // Constructor
            
        }

        public void DisplayMenu(){
            Console.WriteLine("Hello and welcome to the Multi Factory. What do you want to do?");
            HandleInput(MenuSelection(new string[]{"Order a product", "List your orders", "Close the program"}));
        }
        public void HandleInput(int inputNum){
            switch (inputNum)
            {
                case 1:
                    Order();
                break;

                case 2:
                    ListOrders();
                break;
                
                case 3:
                    Environment.Exit(0);
                break;
                
                default:
                    Environment.Exit(0);
                break;
            }
        }
        public void ListOrders(){

        }
        private void AskProperties<T>(string[] questions){
            List<string> answers = new List<string>();

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                answers.Add(Console.ReadLine());
            }
            
            object newProduct = Activator.CreateInstance(typeof(T), answers);
            this.Orders.AddOrder(newProduct);
        }
        private void Order(){
            Console.WriteLine("What product do you want to order?");
            int product = MenuSelection(new string[]{"Candy", "Car", "Lace", "Tofu"});
            switch (product)
            {
                case 1:
                    AskProperties<Candy>(Candy.OrderQuestions);
                break;

                case 2:
                    AskProperties<Car>(Car.OrderQuestions);
                break;

                case 3:
                    AskProperties<Lace>(Lace.OrderQuestions);
                break;
                    
                case 4:
                    AskProperties<Tofu>(Tofu.OrderQuestions);
                break;
                
                default:
                    Environment.Exit(400);
                break;
            }
        }
        private int MenuSelection(string[] menuOptions){
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] - {menuOptions[i]}");
            }
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}
