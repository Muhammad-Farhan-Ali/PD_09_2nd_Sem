using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AbsoluteGradedCourse:Course
    {
        public AbsoluteGradedCourse(string courseName, float marks):base(courseName,marks)
        {
            if (grade == "F") { this.Status = false; }
        }
        public new void setMarks(double marks) { this.marks = marks; this.grade = giveGradeFromMarks(marks); }
        public new void setName(string name) { this.courseName = name; }
        public new string getName() { return this.courseName; }
        public new double getMarks() { return this.marks; }
        public new string getGrade() { return this.grade; }
    }
}
