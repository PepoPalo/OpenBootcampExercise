using Microsoft.EntityFrameworkCore;
using OpenBootcampBackend.Models.DataModels;
using System.Security.Policy;

namespace OpenBootcampBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }

        // TODO: Add DBSets (Tables of our Data base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
