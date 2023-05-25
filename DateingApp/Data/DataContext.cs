using DateingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DateingApp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
            
        }
        public DbSet<AppUser> Users { get; set; }     // Users table Name

    }
}


/// A DbContext instance represents a session with the database and can be used to query and save
///     instances of your entities. DbContext is a combination of the Unit Of Work and Repository patterns.