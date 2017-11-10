namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine().Split();
                var studentName = studentInfo[0];
                var studentGrades = new List<double>();

                for (int j = 1; j < studentInfo.Length; j++)
                {
                    studentGrades.Add(double.Parse(studentInfo[j]));
                }

                var student = new Student
                {
                    Grades = studentGrades,
                    Name = studentName
                };

                students.Add(student);
            }

            foreach (var student in students.Where(a => a.AverageGrade >= 5).OrderBy(a => a.Name).ThenByDescending(b => b.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}