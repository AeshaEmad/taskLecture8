using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityExamSystem.Models
{
    public class Doctor
    {

        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Login()
        {
            Console.Write("Enter Doctor Username: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (user == Username && pass == Password)
            {
                Console.WriteLine(" Doctor Login Successful!");
                return true;
            }
            else
            {
                Console.WriteLine(" Invalid Doctor Login.");
                return false;
            }
        }

        public Question[] CreateQuestions()
        {
            Console.Write("Enter number of questions: ");
            int n = int.Parse(Console.ReadLine());
            Question[] qArr = new Question[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n--- Enter data for Question " + (i + 1) + " ---");
                qArr[i] = new Question();

                Console.Write("Enter question type (TrueFalse / ChooseOne / Multiple): ");
                qArr[i].Type = Console.ReadLine();

                Console.Write("Enter difficulty (Easy / Hard): ");
                qArr[i].Level = Console.ReadLine();

                Console.Write("Enter question text: ");
                qArr[i].Text = Console.ReadLine();

                Console.Write("Enter mark for this question: ");
                qArr[i].Mark = double.Parse(Console.ReadLine());

                if (qArr[i].Type == "TrueFalse")
                {
                    Console.Write("Enter correct answer (True / False): ");
                    qArr[i].CorrectAnswer = Console.ReadLine();
                }
                else if (qArr[i].Type == "ChooseOne" || qArr[i].Type == "Multiple")
                {
                    Console.Write("How many options? ");
                    int optCount = int.Parse(Console.ReadLine());
                    string[] opts = new string[optCount];
                    for (int j = 0; j < optCount; j++)
                    {
                        Console.Write("Enter option " + (j + 1) + ": ");
                        opts[j] = Console.ReadLine();
                    }
                    qArr[i].Options = opts;

                    Console.Write("Enter correct answer (write exact text): ");
                    qArr[i].CorrectAnswer = Console.ReadLine();
                }
            }

            Console.WriteLine("\n All questions saved successfully!");
            return qArr;
        }
    }
}
