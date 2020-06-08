using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Reflection;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student dennis = new Student("Dennis", 1, 0, 0.0);
            Student moe = new Student("Moe", 2, 0, 0.0);
            
            moe.AddGrade(4, 4.0);
            Console.WriteLine(moe.ToString());
            Console.WriteLine(moe.GetGradeLevel(moe.NumberOfCredits));

            dennis.AddGrade(4, 3.5);
            Console.WriteLine(dennis.ToString());
            Console.WriteLine(dennis.GetGradeLevel(dennis.NumberOfCredits));

            List<Student> enrolledStudents = new List<Student>();
            enrolledStudents.Add(moe);
            enrolledStudents.Add(dennis);
            
            
            Course LaunchCode = new Course("C#", "Amer", enrolledStudents);
            Console.WriteLine(LaunchCode.ToString());
        



        }
    }
    
}
