using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuizGame.Program;

namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods.StartSession();





         QuizForm firstQuiz = new QuizForm();

        }

        public class Questionnaire
        {
            public int QuestionNumber { get; set; }
            public string FirstQuestion { get; set; }
            public string RightAnswer { get; set; }
            public string FalseAnswer1 { get; set; }
            public string Falseanswer2 { get; set; }
        }

    }
    }
}
