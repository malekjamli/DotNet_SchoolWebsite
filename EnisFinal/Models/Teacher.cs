namespace EnisFinal.Models
{
    
    public class Teacher
    {
        public int Id { get; set; }

        public string TeacherName { get; set; }

        public string Description { get; set; }

        public string mail { get; set; }

        public string PhoneNumber { get; set; }
        public Domain? Domain { get; set; }



        public IList<Course>? Courses { get; set; }
    }
}
