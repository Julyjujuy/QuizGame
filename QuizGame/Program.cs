using System;
using System.Collections.Generic;
using System.IO;



namespace QuizGame
{
    internal class Program
    {
        const int NR_ANSWERS = 3;
        const int NR_QUESTIONS = 3;
        static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dataquiz.xml");

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
            LogicMethods.Serialize(qAndA, filePath);
            qAndA = LogicMethods.Deserialize(filePath);
            foreach (Formular var in qAndA)
            {
                UIMethods.DisplayQuestion(var.question1, var.answers[0], var.answers[1], var.answers[2]);
                LogicMethods.CheckAnswer(var.answerIndex);
            }
            UIMethods.LetsTakeAPause();
        }
    }
}
