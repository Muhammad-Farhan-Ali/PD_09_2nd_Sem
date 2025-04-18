using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Project
    {
        private int count=0;
        string ProjectName;
        List<Course> courses=new List<Course>();

        public Project(string projectName)
        {
            ProjectName = projectName;
        }
        public string getProjectName()
        {
            return this.ProjectName;
        }
        public void Pass(Course course)
        {
            this.courses.Add(course);
        }
        public void getProjectInfo()
        {
            Console.WriteLine(ProjectName + ":");
            Console.WriteLine();
            for (int i = 0; i < this.courses.Count; i++)
            {
                Console.WriteLine("CourseName: " + courses[i].getName());
                Console.WriteLine("CourseMarks: " + courses[i].getMarks());
                Console.WriteLine("CourseGrade: " + courses[i].getGrade());
                Console.WriteLine();
                if(courses[i].Status)
                {
                    count++;
                }
            }
            if (count >= 3) { Console.WriteLine("Pass"); }
            else { Console.WriteLine("Fail"); }
            
        }
    }
}
