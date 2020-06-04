using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student dennis = new Student("Dennis",1,1,4.0);
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
        }

    }

    public class Course
    {
        private string courseTitle {get; set;}
        private List <Student> roster {get; set;}
        private List <int> grades {get; set;}
     }
    public class Teacher
    {
        private string FirstName {get; set;}
        private string LastName {get; set;}
        private string Subject {get;set;}
        private int YearsTeaching {get; set;}
    }
}
