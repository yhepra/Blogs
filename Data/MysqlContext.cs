using Blogs.Controllers;
using Blogs.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
