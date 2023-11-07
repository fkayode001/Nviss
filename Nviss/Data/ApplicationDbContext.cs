using Microsoft.EntityFrameworkCore;
using Nviss.Models;

namespace Nviss.Data
{
    public class ApplicationDbContext :DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<MailTracker> MailTrackers { get; set; }
        public DbSet<Document> Documents { get; set; }
    }

}
