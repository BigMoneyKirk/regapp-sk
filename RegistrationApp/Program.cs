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
        public static string addCourse = "";
        public static string studentFirstName = "";
        public static string studentLastName = "";
        public static string searchCourse = "";
        public static string findStudent = "";

        // main
        static void Main(string[] args)
        {
            DisconnectionHelper.GetDisconnectedResult(DisconnectionHelper.GetConnectionString(), DisconnectionHelper.GetQueryString());
            
            // comment out here
            Prompt();
            prompt = Console.ReadLine();
            try
            {
                option = Int32.Parse(prompt);
            }
            catch(Exception noChars)
            {
                Console.WriteLine(noChars.Message);
            }
            SwitchStatements();
            // end the comment out here
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
                    addCourse = Console.ReadLine();

                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Enter the first name of the student you want to add: ");
                    studentFirstName = Console.ReadLine();

                    Console.WriteLine("Enter the last name of the student you want to add: ");
                    studentLastName = Console.ReadLine();

                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Enter the name of the course you want to find: ");
                    searchCourse = Console.ReadLine();
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Enter the name of the student you want to find: ");
                    findStudent = Console.ReadLine();

                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Guess you found what you were looking for. Goodbye! :)");
                    Thread.Sleep(5000);
                    System.Environment.Exit(1);
                    break;
            } // switch
        } // SwitchStatement
    }
}
