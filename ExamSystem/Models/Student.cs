using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityExamSystem.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Login()
        {
            Console.Write("Enter Student Username: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (user == Username && pass == Password)
            {
                Console.WriteLine(" Student Login Successful!");
                return true;
            }
            else
            {
                Console.WriteLine(" Invalid Student Login.");
                return false;
            }
        }

        public void StartExam(Question[] questions)
        {



            Exam ex = new Exam();

            ex.Questions = questions;
            ex.TakeExam();
        }
    }
}
