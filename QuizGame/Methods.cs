using System;



namespace QuizGame
{
    internal class UIMethods
    {
        public static void StartSession()
        {
            Console.WriteLine("Welcome to this console Quiz game. You will be asked to imput some questions and their answerws. Thanks for partecipate!");
        }
        public static string AskQuestion() 
        {
            Console.WriteLine("Please imput a question for this game. Information will be stored only during this session.");
            string q1 = Console.ReadLine();
            return q1;
        }
        public static string AskAnswer()
        {
            Console.WriteLine("Please imput an answer to this question.");
            string a1 = Console.ReadLine();
            return a1;
        }
        public static int AskAnswerHolder()
        {
            Console.WriteLine("Tell me which question is the correct one: 1, 2, or 3?");
            string rightAn = Console.ReadLine();
            int rightAnNum = Convert.ToInt32(rightAn);
            return rightAnNum;
        }
        
    }
}
