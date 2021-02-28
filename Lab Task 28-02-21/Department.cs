using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_02_21
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }

        }
        private Student[] students;
        private int studentCount;
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }
        public Department(){
            students = new Student[40];
        }
    public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            students = new Student[40];
        }
        public void AddStudent(params Student[] arrStudent)
        {
            foreach(var s in arrStudent)
            {
                students[studentCount++] = s;
                s.Department = this;
            }
        }
        public void AllStudents()
        {
             for(int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }
        public Student GetStudent(string id){
            return null;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
        }
    }
}
