using System;
using System.Collections.Generic;
namespace QuizGame
{
    [Serializable]
    public class Formular
    {
        public string question1;
        public List<string> answers;
        public int answerIndex;
        public Formular()
        {
            answers = new List<string>();
        }
    }

}
