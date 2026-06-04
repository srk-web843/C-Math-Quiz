using System;
using System.Collections.Generic;

namespace MathQuiz
{
    public class App
    {
        static void Main(string[] args)
        {
            List<string> questions = new List<string>();
            {
                questions.Add("What is 6*6?");
                questions.Add("What is 4^3?");
                questions.Add("What is 72/8?");
            }
            List<int> answers = new List<int>();
            {
                answers.Add(36);
                answers.Add(64);
                answers.Add(9);
            }
            float result = Asker(questions, answers);
            Console.WriteLine("Your final score is: " + result);
        }
        static float Asker(List<string> qs, List<int> ans)
        {
            float score = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(qs[i]);
                string? a = Console.ReadLine();
                if (!int.TryParse(a, out int answer)) {
                    Console.WriteLine("Error: Invalid answer.");
                    break;
                }
                if (answer == ans[i])
                {
                    Console.WriteLine("Correct!");
                    score++;
                } 
                else
                {
                    Console.WriteLine("Nice try.");
                }
            }
            float finalScore = (score/3) * 100;
            return finalScore;
        }
    }
}
