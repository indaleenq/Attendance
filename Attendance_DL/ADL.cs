using System;
using System.Collections.Generic;

namespace Attendance_DL
{
    public class ADL
    {
        public static Dictionary<string, string> students = new Dictionary<string, string>();
        public static Dictionary<string, string> attendanceRecords = new Dictionary<string, string>();

        public static void AddStudent()
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

        public static void RemoveStudent()
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
    }
}
