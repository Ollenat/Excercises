using System;
using System.Collections.Generic;

namespace MultiFactory
{
    class Tofu 
    {
        public static string[] OrderQuestions = new string[]{"How much tofu do you want? (litres)", "What seasoning do you want on your tofu?"};
        double Volume;
        string Seasoning;

        public Tofu(List<string> answers){
            Volume = Convert.ToDouble(answers[0]);
            Seasoning = answers[1];
        }
        public string GetProductInfo(){
            return $"Tofu, Volume: {Volume}, Seasoning: {Seasoning}";
        }
    }
}
