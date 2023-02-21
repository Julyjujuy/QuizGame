using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace QuizGame
{
    internal class LogicMethods
    {
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
    }
}
