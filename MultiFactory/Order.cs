using System;
using System.Collections.Generic;
namespace MultiFactory
{
    class Orders
    {
        List<Candy> OrderedCandy = new List<Candy>();
        List<Car> OrderedCars = new List<Car>();
        List<Lace> OrderedLaces = new List<Lace>();
        List<Tofu> OrderedTofu = new List<Tofu>();
        public void AddOrder(object productType){
            switch (productType)
            {
                case Candy:
                    Console.WriteLine("Ordered candy!");
                break;
                
                case Car:
                
                break;

                case Lace:
                
                break;

                case Tofu:
                
                break;

                default:
                    Environment.Exit(400);
                break;
            }
        }
    }
}
