using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public class CheckboxQuestion : Question
    {
        public List<string> CorrectAnswers { get; set; }
        public List<string> UserResponse { get; set; }

        public CheckboxQuestion(List<string> correctAnswers, string prompt, List<string> options) : base (prompt, options)
        {
            CorrectAnswers = correctAnswers;
            UserResponse = new List<string>() { };
        }

        


        public override bool GradeQuestion()
        {
            bool complete = false;
            Console.WriteLine("Your answers(one per line, press enter when done: ");
            do
            {

                
                string input = Console.ReadLine();
                if (input == "")
                {
                    complete = true;
                } else
                {
                    UserResponse.Add(input);
                }
               

            } while (complete == false);

            int numCorrect = 0;

            foreach (string answer in UserResponse)
            {
                
                if (CorrectAnswers.Contains(answer))
                {
                    numCorrect++;
                }
                else
                {
                    numCorrect--;
                }
            }

            if(numCorrect == CorrectAnswers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        
    }
}
