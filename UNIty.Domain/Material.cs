using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIty.Domain
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int LecturerId { get; set; }
        public Lecturer Uploader { get; set; }
    }

}
