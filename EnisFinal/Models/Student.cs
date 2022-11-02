using System.Diagnostics;

namespace EnisFinal.Models
{
       public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Description_pfe { get; set; }

        public Domain? Domain_pfe { get; set; }
        public int GroupeId { get; set; }
        public Groupe? Grade { get; set; }
        public ReportCard? ReportCard { get; set; }

    }
}
