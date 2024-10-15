using Microsoft.EntityFrameworkCore;

namespace VueAspCoreProject.Server.Repository
{
    public class NoteContext : DbContext
    {
        //public NoteContext() : base(DbContextOptions)//("DefaultConnection")
        //{ }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder
                .UseSqlServer(
                    connectionString,
                    providerOptions => { providerOptions.EnableRetryOnFailure(); });
        }

    }

    public class Note
    {
        public int NoteId { get; set; }
        public string? NoteName { get; set; }
        public string? NoteContent { get; set; }
        public string? NoteColor { get; set; }

    }
}
