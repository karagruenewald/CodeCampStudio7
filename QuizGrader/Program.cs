using System;
using System.Collections.Generic;

namespace QuizGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz newQuiz = new Quiz();

            Question q1 = new MultipleChoiceQuestion("Australia", "What's the biggest island?", new List<string>() { "Australia", "New Zealand", "Guam", "Madagascar" });

            newQuiz.AddQuestion(q1);

            Question q2 = new TrueFalseQuestion("There are 3 quarts in a gallon", "False");

            newQuiz.AddQuestion(q2);

            List<string> q3Answers = new List<string>() { "1", "3" };
            List<string> q3Options = new List<string>() { "1. Square", "2. Triangle", "3. Rectangle" };
            Question q3 = new CheckboxQuestion(q3Answers, "Which of these have 4 sides?", q3Options);

            newQuiz.AddQuestion(q3);



            newQuiz.Administer();
        }
    }
}
