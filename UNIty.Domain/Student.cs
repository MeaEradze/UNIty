using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml;

namespace UNIty.Domain
{
    public class Student : User
    {
        public string StudentId { get; set; }
        public ICollection<Subject> EnrolledSubjects { get; set; }
        public ICollection<Score> Scores { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public Timetable Timetable { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }

}
