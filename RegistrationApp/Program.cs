using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using University.Users;
using University.Courses;
using University;

namespace RegistrationApp
{
    class Program
    {
        // fields
        private static int option = 0;
        private static string prompt = "";

        // main
        static void Main(string[] args)
        {
            Prompt();
            prompt = Console.ReadLine();
            option = Int32.Parse(prompt);

            SwitchStatements();
        } // main

        private static void Prompt()
        {
            Console.WriteLine("Welcome to the Kirkland University App!");
            Console.WriteLine("Which option would you like to access?");
            Console.WriteLine("1. Add a course");
            Console.WriteLine("2. Add a student");
            Console.WriteLine("3. Search a course");
            Console.WriteLine("4. Search a student");
            Console.WriteLine();
        } // Prompt

        private static void SwitchStatements()
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the name of the course you want to add: ");
                    string course = Console.ReadLine();
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Enter the first name of the student you want to add: ");
                    string studentFirstName = Console.ReadLine();

                    Console.WriteLine("Enter the last name of the student you want to add: ");
                    string studentLastName = Console.ReadLine();

                    Console.ReadLine();
                    break;

                case 3:
                    break;

                case 4:
                    break;

                default:
                    break;
            } // switch
        } // SwitchStatement
    }
}
