using BlogApp.Models;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data;

public class BlogAppDbContext : DbContext
{
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Env.GetString("DATABASE_URL");

        optionsBuilder.UseNpgsql(connectionString);
    }
}
