using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApp.Data;
public class AppDbContext: DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Comment> Comments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=blogapp;User Id=sa;Password=@myPassWord;Integrated Security=True;TrustServerCertificate=true;Trusted_Connection=false");
    }
}