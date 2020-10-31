using System;

namespace SarasTreasures.Models
{
    public class Quiz
    {
        // instance variables
        private const string CORRECT = "Correct!";
        private const string INCORRECT = "Incorrect!";
        
        // properties
        public string UserInput1 { get; set; }  // question 1
        public string Result1 { get; set; }
        public string UserInput2 { get; set; }  // question 2
        public string Result2 { get; set; }
        public string UserInput3 { get; set; }  // question 3
        public string Result3 { get; set; }

        // methods
        public void CheckAnswers()
        {
            // remove whitespace + match case to compare
            Result1 = UserInput1.Trim().ToLower() == "black" ? CORRECT : INCORRECT;
            Result2 = UserInput2 == "25%" ? CORRECT : INCORRECT;
            Result3 = UserInput3 == "true" ? CORRECT : INCORRECT;
        }
    }
}