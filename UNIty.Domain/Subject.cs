using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIty.Domain
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public ICollection<Student> EnrolledStudents { get; set; }
        public ICollection<Material> Materials { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
