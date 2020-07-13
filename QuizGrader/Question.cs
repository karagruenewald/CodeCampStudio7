using System;
using System.Collections.Generic;

namespace QuizGrader
{
    public abstract class Question
    { 

        public string Prompt { get; set; }
        public List<string> Options { get; set; }
        

        
        public Question(string prompt, List<string> options)
        {
            Prompt = prompt;
            Options = options;
        }


        public void PromptQuestion()
        {
            Console.WriteLine(Prompt);
            foreach (string option in Options)
            {
                Console.WriteLine(option);
            }
        }


        public abstract bool GradeQuestion();



    }
}
