
using NotesManagementApp.Models;
using System.Data.Entity;


namespace NotesManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Notes> Notess { get; set; }
    }
}