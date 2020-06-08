using System;
using System.Collections.Generic;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            double qualityScore = courseCredits * grade;
            NumberOfCredits += courseCredits;
            double gpaCalc = qualityScore / NumberOfCredits;
            Gpa = gpaCalc;
            
            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            if (NumberOfCredits >= 30 && NumberOfCredits <= 59)
            {
                return "Sophmore";
            }
            if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return Name + " ( ID: " + StudentId + " Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }

    }
}
