using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Students
    {

        public int StudentId { get; set; }  
        public string? StudentName { get; set; }

        public int StudentAge { get; set; } 
        public string StudentCity { get; set; }    

        public Students(int studentId, string? studentName, int studentAge, string studentCity)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
            this.StudentAge = studentAge;
            this.StudentCity = studentCity;  
        }
    }
}
