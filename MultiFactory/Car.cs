using System;
using System.Collections.Generic;

namespace MultiFactory
{
    class Car 
    {
        public static string[] OrderQuestions = new string[]{"What license plate number do you want the car to have?", "What colour do you want you car?", "What car model do you want?"};
        string LicensePlateNumber;
        string Colour;
        string CarModel;

        public Car(List<string> answers){
            LicensePlateNumber = answers[0];
            Colour = answers[1];
            CarModel = answers[2];
        }
        public string GetProductInfo(){
            return $"Car, License Plate Number: {LicensePlateNumber}, Colour: {Colour}, Car Model: {CarModel}";
        }
    }
}
