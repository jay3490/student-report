using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{ 
    public class Marks
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int SubjectMarks { get; set; }

        public Marks(int studentId, int subjectId, int subjectMarks)
        {
            this.StudentId = studentId;
            this.SubjectId = subjectId;
            this.SubjectMarks = subjectMarks;
        }
    }
}
