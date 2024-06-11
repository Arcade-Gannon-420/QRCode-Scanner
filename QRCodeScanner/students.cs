using System.Collections.Generic;

namespace QRCodeScanner
{
    internal class students
    {
        // Define the Student class inside the students class
        public class Student
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Gender { get; set; }
            public string Course { get; set; }
            public string Year { get; set; }
            public string SchoolYear { get; set; }
            public string Semester { get; set; }
            public byte[] Photo { get; set; }
            public string TimeIn { get; set; }

            public string TimeOut { get; set; }
            public string Title { get; set; }
            public string SubjectCode { get; set; }
            public string Schedule { get; set; }
            public string enrollmentStatus { get; set; }


            public List<Subject> Subjects { get; set; } = new List<Subject>(); // Include Subjects property here

            public class Subject
            {
                public string Title { get; set; }
                public string SubjectCode { get; set; }
                public string Schedule { get; set; }
                public string enrollmentStatus { get; set; }
            }
        }
    }
}
