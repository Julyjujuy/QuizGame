using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace QuizGame
{
    [Serializable]
    public class Formular
    {
        public string q1;
        public List<string> answers;
        public int answerIndex;

        public Formular()
        {
            answers = new List<string>();
        }
    }

}
