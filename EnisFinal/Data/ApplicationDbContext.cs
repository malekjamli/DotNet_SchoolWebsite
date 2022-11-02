using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EnisFinal.Models;

namespace EnisFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EnisFinal.Models.Course> Course { get; set; }
        public DbSet<EnisFinal.Models.Groupe> Groupe { get; set; }
        public DbSet<EnisFinal.Models.Student> Student { get; set; }
        public DbSet<EnisFinal.Models.ReportCard> ReportCard { get; set; }
        public DbSet<EnisFinal.Models.Teacher> Teacher { get; set; }
        public DbSet<EnisFinal.Models.Domain> Domain { get; set; }
    }
}