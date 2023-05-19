using System;
using System.Collections.Generic;
using Attendance_DL;

namespace Attendance_BL
{
    public class ABL
    {
        public static Dictionary<string, string> students = new Dictionary<string, string>();
        public static Dictionary<string, string> attendanceRecords = new Dictionary<string, string>();
        public static void RecordAttendance()
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
    }
}
