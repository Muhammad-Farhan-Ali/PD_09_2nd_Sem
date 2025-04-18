using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Course
    {
        public bool Status=true;
        protected string courseName;
        protected double marks;
        protected string grade;

        public Course(string courseName, double marks)
        {
            if(marks< 0 || marks>100) { Console.WriteLine("Invalid input"); return; }
            this.courseName = courseName;
            this.marks = marks;

            this.grade = giveGradeFromMarks(marks);
        }

        public virtual string giveGradeFromMarks(double marks)
        {
            if (marks>=90 && marks <= 100)       { return "A+"; }
            else if (marks >= 80 && marks <= 89) { return "A"; }
            else if (marks >= 70 && marks <= 79) { return "B"; }
            else if (marks >= 60 && marks <= 69) { return "C"; }
            else if (marks >= 50 && marks <= 59) { return "D"; }
            else if (marks >= 0 && marks <= 49)  { return "F"; }
            return "";
        }
        public void setMarks(double marks) { this.marks = marks; this.grade = giveGradeFromMarks(marks); }
        public void setName(string name) { this.courseName = name; }
        public string getName() { return this.courseName; }
        public double getMarks() { return this.marks; }
        public string getGrade() { return this.grade; }
    }
}
