using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class TrueFalseQuestion : Question
    {
        public string CorrectAnswer { get; set; }
        public string UserResponse { get; set; }

        // Create overloaded constructor for this subclass of Question
        /*
         * Needs to accept (prompt, correctAnswer)
         * Pass a new List object of { "True", "False" } to the Options param
         */
        public TrueFalseQuestion(string prompt, string correctAnswer)
            : base(prompt, new List<string>() { "True", "False" })//generates a new list object prefilled with the only two options
        {
            CorrectAnswer = correctAnswer;
            UserResponse = "";
        }

        
        public override bool GradeQuestion()
        {
            Console.WriteLine("Your answer: ");
            UserResponse = Console.ReadLine();

            return UserResponse.Equals(CorrectAnswer);
        }
    }
}
