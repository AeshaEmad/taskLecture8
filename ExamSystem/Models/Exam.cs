using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityExamSystem.Models
{
    public class Exam
    {

        public string ExamType { get; set; }
        public Question[] Questions { get; set; }
        public double TotalMarks { get; set; }
        public double StudentMarks { get; set; }

        public void TakeExam()
        {
            Console.WriteLine("\n=== Starting " + ExamType + " Exam ===");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine("\n----------------------");
                Console.WriteLine("Q" + (i + 1) + ": ");
                Questions[i].DisplayQuestion();

                Console.Write("Your answer: ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == Questions[i].CorrectAnswer.ToLower())
                {
                    Console.WriteLine(" Correct ");
                    StudentMarks += Questions[i].Mark;
                }
                else
                {
                    Console.WriteLine(" Wrong! Correct answer is: " + Questions[i].CorrectAnswer);
                }

                TotalMarks += Questions[i].Mark;
            }

            Console.WriteLine("\n=== Exam Finished ===");
            Console.WriteLine("Your grade: " + StudentMarks + " / " + TotalMarks);
        }
    }
}
