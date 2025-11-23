using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityExamSystem.Models
{
    public class Question
    {

        public string Text { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public double Mark { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] Options { get; set; }

        public void DisplayQuestion()
        {
            Console.WriteLine("Question: " + Text);
            if (Type == "TrueFalse")
            {
                Console.WriteLine("Answer with True or False");
            }
            else if (Type == "ChooseOne" || Type == "Multiple")
            {
                for (int i = 0; i < Options.Length; i++)
                {
                    Console.WriteLine((i + 1) + ") " + Options[i]);
                }
            }
        }
    }
}
