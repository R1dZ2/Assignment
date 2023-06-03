using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling_Exercise
{
    internal class Classroom
    {
        public int ClassId { get; set; }
        public string ClassTeacher { get; set; }
        public string Section { get; set; }

        public Classroom(int classId, string classTeacher, string section)
        {
            ClassId = classId;
            ClassTeacher = classTeacher;
            Section = section;
        }
    }
}
