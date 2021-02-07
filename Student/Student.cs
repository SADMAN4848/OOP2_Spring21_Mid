using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
            {
            private string name;
            private string id;
            private string department;
            private float cgpa;

            public Student(){
            }
            public Student(string name, string id, string department, float cgpa){
                this.name = name;
                this.id = id;
                this.department = department;
                this.cgpa = cgpa;
            }
        public void ShowInfo(){
                Console.WriteLine("Student's name: " +name);
                Console.WriteLine("Student's id: " +id);
                Console.WriteLine("Student's department: " + department);
                Console.WriteLine("Student's CGPA: "+ cgpa);
                Console.WriteLine();
            }
    }
}
