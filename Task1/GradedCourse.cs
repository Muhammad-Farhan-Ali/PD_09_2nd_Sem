using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class GradedCourse:Course
    {
        public GradedCourse(string courseName, float marks) : base(courseName, marks)
        {
            if(grade=="0" || grade == "-3") { this.Status = false; }
        }
        public override string giveGradeFromMarks(double marks)
        {
            if (marks >= 90 && marks <= 100)     { return "12"; }
            else if (marks >= 80 && marks <= 89) { return "10"; }
            else if (marks >= 70 && marks <= 79) { return "7"; }
            else if (marks >= 60 && marks <= 69) { return "4"; }
            else if (marks >= 50 && marks <= 59) { return "2"; }
            else if (marks >= 40 && marks <= 49) { return "0"; }
            else if (marks >= 0 && marks <= 39)  { return "-3"; }
            return "";
        }
        public new void setMarks(double marks) { this.marks = marks; this.grade = giveGradeFromMarks(marks); }
        public new void setName(string name) { this.courseName = name; }
        public new string getName() { return this.courseName; }
        public new double getMarks() { return this.marks; }
        public new string getGrade() { return this.grade; }
    }
}
