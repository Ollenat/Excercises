using System;

namespace MultiFactory
{
    class Car 
    {
        string LicensePlateNumber;
        string Colour;
        string CarBrand;

        public Car(){
            Console.WriteLine("What colour do you want your car?");
            Colour = Console.ReadLine();
            Console.WriteLine("What license plate number do you want the car to have?");
            LicensePlateNumber = Console.ReadLine();
            Console.WriteLine("What brand do you want the car from?");
            CarBrand = Console.ReadLine();
        }
    }
}
