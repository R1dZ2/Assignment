using System.Threading.Channels;

namespace File_Handling_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom classroom1 = new Classroom(1,"John Smith", "A");
            Classroom classroom2 = new Classroom(2, "Rivera", "B");

            Student student1 = new Student(1,"Ridhwaan",classroom1);
            Student student2 = new Student(2, "Yenefer",classroom2);
            student1.SetMarks();
            student2.SetMarks();

            List<Classroom> classrooms = new List<Classroom> { classroom1, classroom2};
            List<Student> students = new List<Student> {  student1, student2 };

            ReportCard reportCard = new ReportCard(students, classrooms);
            reportCard.GenerateReportCard();
            reportCard.PrintReportCard();

        }
    }
}