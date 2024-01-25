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
/*{
  "message": "User registered successfully. Please check your email for verification. eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImVnYmV0aWltbXlAZ21haWwuY29tIiwibmFtZWlkIjoiMCIsIk9UUCI6Ijk0OTQwMSIsIlBhc3N3b3JkIjoia2VsZSIsIkZpcnN0TmFtZSI6InN0cmluZyIsIkxhc3ROYW1lIjoiJDJhJDEwJEI0dXROR2UxQlV2SGRqb0tFNzF1dnViL05mc3h6Z3BsZnVmYWxSdVBQLkd3dkM3cDF4ajh1IiwibmJmIjoxNzA1OTE0NDQ1LCJleHAiOjE3MDU5MTgwNDUsImlhdCI6MTcwNTkxNDQ0NX0.RwgveUIMQ3dXdBfpiSYCEezrWoFUMaY-EdGa0KRDT0o"
}*/