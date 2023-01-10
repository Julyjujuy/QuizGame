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

            List<Formular> QandA = new List<Formular>();
            QandA.Add(form);


            string path = @"C:\Users\tanti\Desktop\C# projects\Project Data\dataquiz.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Formular>));
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, QandA);
            };
            using (FileStream file = File.OpenRead(path))
            {
                QandA = (List<Formular>)serializer.Deserialize(file);
            }
            foreach (Formular var in QandA)
            {
                UIMethods.DisplayQuestion(var.q1, var.ans1, var.ans2, var.ans3);
                UIMethods.CheckAnswer(var.answerIndex);
            }
            UIMethods.LetsTakeAPause();
        }
    }
}
