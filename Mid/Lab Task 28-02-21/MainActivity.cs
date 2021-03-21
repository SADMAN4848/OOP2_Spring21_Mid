using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_02_21
{
    class MainActivity
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science","CS");
            Department d2 = new Department("Electrical Engineering", "EEE");
            Student s1 = new Student("Sadman Rahman", "123", 2.5f);
            Student s2 = new Student("Mehrab Faisal", "124", 2.75f);
            Student s3 = new Student("Rashedul Hasan", "126", 3.3f);

            d1.AddStudent(s1,s2);
            s1.Department = d1;
            s2.Department = d1;
            s1.Department.ShowInfo();
            
            d2.AddStudent(s3);
            s3.Department = d2;
            

            d1.AllStudents();
            d2.AllStudents();

 
        }
    }
}
