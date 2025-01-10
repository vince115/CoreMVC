using Microsoft.EntityFrameworkCore;
using CoreMVC.Models;

namespace CoreMVC.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Staff> Staffs { get; set; }
    }
}
