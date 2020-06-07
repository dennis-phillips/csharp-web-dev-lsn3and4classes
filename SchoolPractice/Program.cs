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
            Student dennis = new Student("Dennis", 1, 30, 3.0);
            Student moe = new Student("Moe", 2, 70, 3.0);
            Console.WriteLine(moe.ToString());
            moe.AddGrade(4, 4.0);
            Console.WriteLine(moe.GetGradeLevel(moe.NumberOfCredits));
        
        

        }
    }
    
}
