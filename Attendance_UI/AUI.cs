using System;
using System.Collections.Generic;
using Attendance_DL;

namespace Attendance_UI
{
    public class AUI
    {
        public static Dictionary<string, string> students = new Dictionary<string, string>();
        public static Dictionary<string, string> attendanceRecords = new Dictionary<string, string>();

        public static void ViewAttendanceRecords()
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
