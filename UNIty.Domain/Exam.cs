using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace UNIty.Domain
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Title { get; set; }
        public DateTime ExamDate { get; set; }
        public TimeSpan Duration { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Score> Scores { get; set; }
    }

}
