namespace EnisFinal.Models
{
    public class Groupe
    {

        public int Id { get; set; }
        public string ClassNumber { get; set; }

        public IList<Student>? Students { get; set; }

    }
}
