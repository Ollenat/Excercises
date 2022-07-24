using System;
using System.Collections.Generic;

namespace MultiFactory
{
    class Lace 
    {   
        public static string[] OrderQuestions = new string[]{"How long do you want the lace? (cm)", "What colour do you want the lace?"};
        double Length;
        string Colour;
        public Lace(List<string> answers){
            Length = Convert.ToInt16(answers[0]);
            Colour = answers[1];
        }
        public string GetProductInfo(){
            return $"Lace, Length: {Length}cm, Colour: {Colour}";
        }
    }
}
