using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class MultipleChoiceQuestion : Question
    {
        
        public string CorrectAnswer { get; set; }
        public string UserResponse { get; set; }

        public MultipleChoiceQuestion(string correctAnswer, string prompt, List<string> options)
            : base(prompt, options)
        {
            CorrectAnswer = correctAnswer;
            UserResponse = "";
        }

        public override bool GradeQuestion()
        {
            //Get user response
            //Check user response against correct answer
            Console.WriteLine("Your answer: ");
            UserResponse = Console.ReadLine();
            //if (UserResponse.Equals(CorrectAnswer))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return UserResponse.Equals(CorrectAnswer);
        }
    }
}
