using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Subjects
    {
        public string? SubjectName { get; set; }
        public int SubjectId { get; set; }

        public Subjects( int subjectId, string subjectName)
        { 
            this.SubjectName = subjectName;
            this.SubjectId = subjectId;
        }
    }
}
