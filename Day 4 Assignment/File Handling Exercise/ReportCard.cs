using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling_Exercise
{
    internal class ReportCard
    {
        public List<Classroom> Classroom { get; set; }
        public List<Student> Student { get; set; }

        public ReportCard(List<Student> sObj, List<Classroom> cObj)
        {
            Student = sObj;
            Classroom = cObj;
        }
        public void GenerateReportCard()
        {

            string path = @"C:\Users\ridhwaan.noorooya\source\repos\c# Training\Advanced C#\Day 4 Assignment\File Handling Exercise\StudentsDetails.txt";
            FileStream fileStream;
            if (File.Exists(path))
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Write);
                Console.WriteLine("Existing file is opened....");
            }
            else
            {
                fileStream = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                Console.WriteLine("New file stream is created....");
            }

            StreamWriter writer = new StreamWriter(fileStream);
            foreach (var item in Student) 
            {
                writer.WriteLine($"Student ID: {item.StudentId}");
                writer.WriteLine($"Student Name: {item.StudentName}");
                writer.WriteLine($"Student Marks:");
                
                string marksLine = string.Join(" ", item.Marks.Select(marksLine => marksLine.ToString()));
                writer.WriteLine(marksLine);
                writer.WriteLine("\n");
            }

            Console.WriteLine("\nStudents details are saved in the file successfully!");
            writer.Close();

        }
        public void PrintReportCard()
        {
            Console.WriteLine("------------------------------------------------------");

            string path = @"C:\Users\ridhwaan.noorooya\source\repos\c# Training\Advanced C#\Day 4 Assignment\File Handling Exercise\StudentsDetails.txt";
            FileStream fileStream;
            if (File.Exists(path))
            {
                fileStream= new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);
                Console.WriteLine("Existing file is opened....");

                Console.WriteLine("Enter the StudentID whose report is to be generated: ");
                var studentId = Convert.ToInt32(Console.ReadLine());

                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    if (line.StartsWith($"Student ID: {studentId}"))
                    {
                        Console.WriteLine(line);

                        //Student student = Student.Find(s=>s.StudentId== studentId);
                        //Classroom classroom = Classroom.Find(c => c.ClassId == student.Classroom.ClassId);
                        //Console.WriteLine($"Section Name: {classroom.Section}");
                        //Console.WriteLine($"Class Teacher Name: {classroom.ClassTeacher}");

                        Console.WriteLine($"Section Name: {Classroom[studentId - 1].Section}");
                        Console.WriteLine($"Class Teacher Name: {Classroom[studentId - 1].ClassTeacher}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"No Report found for StudentID: {studentId}");
                    }
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Please generate Report Card First");
            }
        }
    }
}
