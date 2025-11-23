using System.Numerics;
using UniversityExamSystem.Models;

namespace UniversityExamSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Examination Management System (Doctor & Student) ===");

        Question[] questionBank = null;

        while (true)
        {
            Console.Write("\nAre you (1) Doctor or (2) Student? (or type 'exit' to quit): ");
            string mode = Console.ReadLine();

            if (mode == "exit" || mode == "quit")
            {
                Console.WriteLine("Exiting system... Goodbye!");
                break;
            }

            if (mode == "1")
            {
                Doctor d = new Doctor();
                d.Username = "doctor1";
                d.Password = "12345";
                d.Name = "Dr. Ahmed";

                if (d.Login())
                {
                    questionBank = d.CreateQuestions();
                }
            }
            else if (mode == "2")
            {
                if (questionBank == null)
                {
                    Console.WriteLine(" No questions available. Please let a doctor add questions first.");
                }
                else
                {
                    Student s = new Student();
                    s.Username = "student1";
                    s.Password = "123";
                    s.Name = "Ali";

                    if (s.Login())
                    {
                        s.StartExam(questionBank);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }

            Console.WriteLine("\n-----------------------------------");

        }
    }
}
