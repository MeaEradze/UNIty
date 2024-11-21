namespace UNIty.Domain
{
    public class Lecturer : User
    {
        public string LecturerId { get; set; }
        public ICollection<Subject> AssignedSubjects { get; set; }
        public ICollection<Material> MaterialsUploaded { get; set; }
        public ICollection<Exam> CreatedExams { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
    }
}
