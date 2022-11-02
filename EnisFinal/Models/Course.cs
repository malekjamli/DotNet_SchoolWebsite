namespace EnisFinal.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public int HoursNumber { get; set; }

        public int coefficient { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

    }
}
