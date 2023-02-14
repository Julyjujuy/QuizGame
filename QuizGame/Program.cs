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
            Formular form = new Formular();
            form.q1 = UIMethods.AskQuestion();
            form.ans1 = UIMethods.AskAnswer();
            form.ans2 = UIMethods.AskAnswer();
            form.ans3 = UIMethods.AskAnswer();
            form.answerIndex = UIMethods.AskAnswerHolder();

            Formular form1 = new Formular();
            form1.q1 = UIMethods.AskQuestion();
            form1.ans1 = UIMethods.AskAnswer();
            form1.ans2 = UIMethods.AskAnswer();
            form1.ans3 = UIMethods.AskAnswer();
            form1.answerIndex = UIMethods.AskAnswerHolder();

            Formular form2 = new Formular();
            form2.q1 = UIMethods.AskQuestion();
            form2.ans1 = UIMethods.AskAnswer();
            form2.ans2 = UIMethods.AskAnswer();
            form2.ans3 = UIMethods.AskAnswer();
            form2.answerIndex = UIMethods.AskAnswerHolder();

            List<Formular> QandA = new List<Formular>();
            QandA.Add(form);
            QandA.Add(form1);
            QandA.Add(form2);

            string path = @"C:\Users\tanti\OneDrive\Dokumente\dataquiz.xml";

            UIMethods.Serialize(QandA, path);

            QandA = UIMethods.Deserialize(path);
            foreach (Formular var in QandA)
            {
                UIMethods.DisplayQuestion(var.q1, var.ans1, var.ans2, var.ans3);
                UIMethods.CheckAnswer(var.answerIndex);
            }
            UIMethods.LetsTakeAPause();
        }
    }
}
