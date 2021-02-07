using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Together
{
    public class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course()
        {
        }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }


        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Course name " + courseName);
            Console.WriteLine("Course code " + courseCode);
            Console.WriteLine("Course credit " + courseCredit);
        }
    }
}
