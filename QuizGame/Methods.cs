using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    internal class Methods
    {
        public static void StartSession()
        {
            Console.WriteLine("Welcome to this console Quiz game. You will be asked to imput some questions and their answerws. Thanks for partecipate!");
        }
        public static string AskFirstQuestion(string question1)
        {
            Console.WriteLine("Please imput a question for this game. Information will be stored only during this session.");
            Console.ReadLine();
            return question1;
        }
        public static string AskFirstCorrectAnswer(string correctAnswer1)
        {
            Console.WriteLine("Please imput the correct answer to this question.");
            Console.ReadLine();
            return correctAnswer1;
        }
        public static string AskFirstWrongAnswer(string wrongAnswer1)
        {
            Console.WriteLine("Please imput a wrong answer to this question.");
            Console.ReadLine();
            return wrongAnswer1;
        }
        public static string AskSecondWrongAnswer(string wrongAnswer2)
        {
            Console.WriteLine("Please imput a wrong answer to this question.");
            Console.ReadLine();
            return wrongAnswer2;
        }




    }
}
