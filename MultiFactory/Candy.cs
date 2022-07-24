using System;
using System.Collections.Generic;

namespace MultiFactory
{
    class Candy 
    {
        public static string[] OrderQuestions = new string[]{"What flavour do you want?", "How many candies do you want? (integer)"};
        string Flavour;
        int Amount;

        public Candy(List<String> answers){
            Flavour = answers[0];
            Amount = Convert.ToInt16(answers[1]);
        } 
        public string GetProductInfo(){
            return $"Candy, Flavour: {Flavour}, Amount: {Amount}";
        }
    }
}
