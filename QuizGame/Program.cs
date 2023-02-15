using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static QuizGame.Program;


namespace QuizGame
{
    internal class Program
    {
        const int NR_ANSWERS = 3;
        const int NR_QUESTIONS = 3;
        const string FILE_PATH = @"C:\Users\tanti\OneDrive\Dokumente\dataquiz.xml";
        public static void Main(string[] args)
        {
            List<Formular> qAndA = new List<Formular>();
            for (int i = 0; i < NR_QUESTIONS; i++)
            {
                Formular form = new Formular();
                form.question1 = UIMethods.AskQuestion();

                for (int j = 0; j < NR_ANSWERS; j++)
                {
                    form.answers.Add(UIMethods.AskAnswer());
                }

                form.answerIndex = UIMethods.AskAnswerHolder();
                qAndA.Add(form);
            }
            UIMethods.Serialize(qAndA, FILE_PATH);
            qAndA = UIMethods.Deserialize(FILE_PATH);
            foreach (Formular var in qAndA)
            {
                UIMethods.DisplayQuestion(var.question1, var.answers[0], var.answers[1], var.answers[2]);
                UIMethods.CheckAnswer(var.answerIndex);
            }
            UIMethods.LetsTakeAPause();
        }
    }
}
