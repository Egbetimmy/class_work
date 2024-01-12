using Microsoft.EntityFrameworkCore;
using UserManagement.Models;
using UserMangement.Models;

namespace UserManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}
