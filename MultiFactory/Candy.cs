using System;
using System.Collections.Generic;
namespace MultiFactory
{
    class Candy 
    {
        public static string[] OrderQuestions = new string[]{};
        string Flavour;
        int Amount;

        public Candy(List<String> answers){
            Flavour = answers[1];
            Amount = Convert.ToInt16(answers[2]);
        } 
    }
}
