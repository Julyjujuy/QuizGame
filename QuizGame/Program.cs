using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static QuizGame.Program;

namespace QuizGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Methods.StartSession();
            
            string question1 = Methods.AskQuestion();
            string answer1 = Methods.AskAnswer();
            string answer2 = Methods.AskAnswer();
            string answer3 = Methods.AskAnswer();
            int answerHolder = Methods.AskAnswerHolder();

            var QandA = new Formular()
            {
                q1 = question1,
                ans1 = answer1,
                ans2 = answer2,
                ans3 = answer3,
                rightAnswerInt = answerHolder
            };

        }
    }
}
