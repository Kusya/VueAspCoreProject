using Microsoft.EntityFrameworkCore;
using System.Xml;
using VueAspCoreProject.Server.Models;

namespace VueAspCoreProject.Server.Repository
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {

        }
    }
}
