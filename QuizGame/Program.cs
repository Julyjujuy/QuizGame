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
        static void Main(string[] args)
        {
            Methods.StartSession();
            string question1 = Methods.AskQuestion();
            string answer1 = Methods.AskAnswer();
            string answer2 = Methods.AskAnswer();
            string answer3 = Methods.AskAnswer();

            var QandA = new Formular()
            

        }
    }
}
