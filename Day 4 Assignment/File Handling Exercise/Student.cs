using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling_Exercise
{
    internal class Student
    {
        public Classroom Classroom { get; set; }
        public int[] Marks { get; set; }    
        public int StudentId { get; set; }
        public string StudentName{ get; set; }

        public Student(int studentId, string studentName,Classroom classroom)
        {
            StudentId = studentId;
            StudentName = studentName;
        }

        public void SetMarks()
        {
            Marks = new int[5];

            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine($"Enter the marks for subject {i + 1} {StudentName}: ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
