using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace advancedDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student List");
            string input;
            Console.WriteLine("Enter \"Add\" to add another student \nEnter \"Clear\" to clear student list \nEnter \"List\" to list student names \nEnter \"Count\" to show count of students \nEnter \"Sort\" to list names in alphabetical order \nEnter \"Save\" to save student list \nEnter \"Exit\" to exit application");
            List<string> students = new List<string>();
            do
            {
                input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "add":
                        addStudent(students);
                        break;
                    case "list":
                        listStudents(students);
                        break;
                    case "clear":
                        clearStudent(students);
                        break;
                    case "count":
                        countStudents(students);
                        break;
                    case "sort":
                        sortStudents(students);
                        break;
                    case "save":
                        saveList(students);
                        break;
                    case "exit":
                        Console.WriteLine("Your program will now end.");
                        break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }
            }
            while (input != "exit");
        }
        static void addStudent(List<string> students)
        {
            Console.WriteLine("Enter Student Name: ");
            string answer = Console.ReadLine();
            students.Add(answer);
        }
        static void clearStudent(List<string> students)
        {
            students.Clear();
        }
        static void listStudents(List<string> students)
        {
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }

        }
        static void countStudents(List<string> students)
        {
            Console.WriteLine(students.Count());
        }
        static void saveList(List<string> students)
        {
            StreamWriter saveit = new StreamWriter("StudentList.txt");
            using (saveit)
            {
                foreach (string names in students)
                {
                    saveit.WriteLine(names);
                }
            }
        }
        static void sortStudents(List<string> students)
        {
            students.Sort();
            foreach (string sorted in students)
            {
                Console.WriteLine(sorted);
            }

        }
    }
}