using System.Collections.Generic;
//using Microsoft.entity
using Microsoft.EntityFrameworkCore;
using System;

namespace VueAspCoreProject.Server.Repository
{
    public class NoteContext : DbContext
    {
        //public NoteContext() : base(DbContextOptions)//("DefaultConnection")
        //{ }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    @"Server=DESKTOP-N26QJ36;Database=NotesDatabase;TrustServerCertificate=true;User Id=sa;Password=9102005",
                    providerOptions => { providerOptions.EnableRetryOnFailure(); });
        }
    }


    public class Note
    {
        public int NoteId { get; set; }
        public string? NoteName { get; set; }
        public string? NoteContent { get; set; }

    }

    //public class BookContext : DbContext
    //{
    //    public BookContext() : base("DefaultConnection")
    //    { }
    //    public DbSet<Book> Bookxs { get; set; }
    //}


    //public class BloggingContext : DbContext
    //{
    //    public DbSet<Blog> Blogs { get; set; }
    //    public DbSet<Post> Posts { get; set; }

    //    public string DbPath { get; }

    //    public BloggingContext()
    //    {
    //        var folder = Environment.SpecialFolder.LocalApplicationData;
    //        var path = Environment.GetFolderPath(folder);
    //        DbPath = System.IO.Path.Join(path, "blogging.db");
    //    }

    //    // The following configures EF to create a Sqlite database file in the
    //    // special "local" folder for your platform.
    //    protected override void OnConfiguring(DbContextOptionsBuilder options)
    //        => options.UseSqlite($"Data Source={DbPath}");
    //}

    //public class Blog
    //{
    //    public int BlogId { get; set; }
    //    public string Url { get; set; }

    //    public List<Post> Posts { get; } = new();
    //}

    //public class Post
    //{
    //    public int PostId { get; set; }
    //    public string Title { get; set; }
    //    public string Content { get; set; }

    //    public int BlogId { get; set; }
    //    public Blog Blog { get; set; }
    //}
}
