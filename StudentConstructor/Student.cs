using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentConstructor
{
    internal class Student
    {
        private int rollNo;
        private string name;
        private int m1, m2, m3;
        int totalMarks;
        float percentage;

        public Student(int rollNo, string name, int m1, int m2, int m3)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;

            totalMarks = m1 + m2 + m3;
            percentage = totalMarks / 3.0f;
        }
        public void display()
        {
            Console.WriteLine("Student Roll Number is:" + rollNo);
            Console.WriteLine("Student Name is:" + name);
            Console.WriteLine("Student Total Marks is:" + totalMarks);
            Console.WriteLine("Student Percentage is:" + percentage + "%");

        }
    }
}
