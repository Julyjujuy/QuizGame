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
        public static void Main(string[] args)
        {
            List<Formular> QandA = new List<Formular>();

            for (int i = 0; i < 3; i++)
            {
                Formular form = new Formular();
                form.q1 = UIMethods.AskQuestion();
                form.answers.Add(UIMethods.AskAnswer());
                form.answers.Add(UIMethods.AskAnswer());
                form.answers.Add(UIMethods.AskAnswer());
                form.answerIndex = UIMethods.AskAnswerHolder();
                QandA.Add(form);
            }


            string path = @"C:\Users\tanti\OneDrive\Dokumente\dataquiz.xml";
            UIMethods.Serialize(QandA, path);
            QandA = UIMethods.Deserialize(path);

            foreach (Formular var in QandA)
            {
                UIMethods.DisplayQuestion(var.q1, var.answers[0], var.answers[1], var.answers[2]);
                UIMethods.CheckAnswer(var.answerIndex);
            }

            UIMethods.LetsTakeAPause();
        }
    }
}
