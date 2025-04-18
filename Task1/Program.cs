using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Project pro1 = new Project("Software Development Project");
            pro1.Pass(new AbsoluteGradedCourse("Software Engineering", 30));
            pro1.Pass(new AbsoluteGradedCourse("Database Mangement", 75));
            pro1.Pass(new GradedCourse("Programming Fundamentals",30));
            pro1.Pass(new GradedCourse("Algorithms and Data Structures",70));

            pro1.getProjectInfo();

            Console.ReadKey();
        }
    }
}
