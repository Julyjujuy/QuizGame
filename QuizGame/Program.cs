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
            UIMethods.StartSession();
            
            string question1 = UIMethods.AskQuestion();
            string answer1 = UIMethods.AskAnswer();
            string answer2 = UIMethods.AskAnswer();
            string answer3 = UIMethods.AskAnswer();
            int answerHolder = UIMethods.AskAnswerHolder();

            var QandA = new Formular()
            {
                q1 = question1,
                ans1 = answer1,
                ans2 = answer2,
                ans3 = answer3,
                answerIndex = answerHolder
            };
            XmlSerializer serializer = new XmlSerializer(typeof(Formular));

            var path = @"C:\Users\tanti\Desktop\C# projects\Project Data\^dataquiz.xml";
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, QandA);
            }
            using (FileStream file = File.OpenRead(path))
            {
               QandA = serializer.Deserialize(file) as Formular;
            }

        }
    }
}
