using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebProgrammingDemoProject.Data.Entities;

namespace WebProgrammingDemoProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<BookLibrary> BookLibraries { get; set; }
    }
}
