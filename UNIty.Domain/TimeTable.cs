using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIty.Domain
{
    public class Timetable
    {
        public int TimetableId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
