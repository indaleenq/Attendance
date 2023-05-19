using System;
using System.Collections.Generic;

namespace Attendance
{
    internal class MainProgram
    {
        static Dictionary<string, string> students = new Dictionary<string, string>();
        static Dictionary<string, string> attendanceRecords = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Attendance Recorder Program!");
            Console.WriteLine("-------------------------------------------");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Record attendance");
                Console.WriteLine("4. View attendance records");
                Console.WriteLine("5. Exit");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        RecordAttendance();
                        break;
                    case "4":
                        ViewAttendanceRecords();
                        break;
                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option selected, please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            if (students.ContainsKey(name))
            {
                Console.WriteLine("Student already exists.");
            }
            else
            {
                students.Add(name, "excused");
                Console.WriteLine("Student added successfully.");
            }
        }

        static void RemoveStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            if (students.ContainsKey(name))
            {
                students.Remove(name);
                attendanceRecords.Remove(name);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student does not exist.");
            }
        }

        static void RecordAttendance()
        {
            Console.WriteLine("Enter 'p' for present, 'a' for absent, or 'e' for excused.");
            Console.WriteLine("--------------------------------------------------------");

            foreach (KeyValuePair<string, string> student in students)
            {
                Console.Write(student.Key + " attendance: ");
                string input = Console.ReadLine().ToLower();

                if (input == "p")
                {
                    attendanceRecords[student.Key] = "present";
                }
                else if (input == "a")
                {
                    attendanceRecords[student.Key] = "absent";
                }
                else if (input == "e")
                {
                    attendanceRecords[student.Key] = "excused";
                }
                else
                {
                    Console.WriteLine("Invalid input. Attendance recorded as excused.");
                    attendanceRecords[student.Key] = "excused";
                }
            }
        }

        static void ViewAttendanceRecords()
        {
            Console.WriteLine("Attendance Records");
            Console.WriteLine("------------------");

            foreach (KeyValuePair<string, string> student in students)
            {
                string attendanceStatus = attendanceRecords.ContainsKey(student.Key) ? attendanceRecords[student.Key] : "excused";
                Console.WriteLine(student.Key + ": " + attendanceStatus);
            }
        }
    }
}