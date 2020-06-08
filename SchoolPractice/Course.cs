using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        

        public string Topic { get; set; }
        public string Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public Course(string topic, string instructor, List<Student> enrolledStudents)
        {
            Topic = topic;
            Instructor = instructor;
            this.enrolledStudents = enrolledStudents;
        }
        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.
        public override string ToString()
        {
            return "********\n" + "Course Title: " + Topic + "\nTeacher: " + Instructor + "\nNumber of students: " + enrolledStudents.Count + "\n*******";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
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

            Course s = toBeCompared as Course;
            return s.Instructor == Instructor;
        }
    }
}
