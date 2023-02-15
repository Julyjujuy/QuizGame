using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

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
            if (!int.TryParse(rightAn, out int rightAnIndex) || rightAnIndex < 1 || rightAnIndex > 3)
            {
                Console.WriteLine("Invalid input, please enter a value between 1 and 3");
                return AskAnswerHolder();
            }
            return rightAnIndex;
        }
        public static void DisplayQuestion(string question, string answer1, string answer2, string answer3)
        {
            Console.WriteLine($"Question: {question}");
            Console.WriteLine($"Answer 1: {answer1}");
            Console.WriteLine($"Answer 2: {answer2}");
            Console.WriteLine($"Answer 3: {answer3}");
            Console.WriteLine("Please input your answer (1, 2 or 3)");
        }
        public static void CheckAnswer(int correctAnswer)
        {
            int count = 0;
            int userAnswer;
            while (count < 3)
            {
                userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Congratulations! your answer is correct");
                    break;
                }
                else
                {
                    count++;
                    if (count < 3)
                        Console.WriteLine("Sorry, your answer is not correct. Try again");
                }
            }
            if (count == 3)
                Console.WriteLine("Sorry, you reached the maximum number of attempts. The correct answer is " + correctAnswer);
        }
        public static void Serialize(List<Formular> data, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Formular>));
            using (FileStream file = File.Create(path))
            {
                serializer.Serialize(file, data);
            }
        }
        public static List<Formular> Deserialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Formular>));
            using (FileStream file = File.OpenRead(path))
            {
                return (List<Formular>)serializer.Deserialize(file);
            }
        }
        public static void LetsTakeAPause()
        {
            Console.ReadLine();
        }

    }
}

