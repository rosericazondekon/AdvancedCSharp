using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blogApp.Models;

namespace blogApp.Data;
public class AppDbContext: DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Comment> Comments { get; set; }
    private const string ConnectionStringFilePath = "con"; 
    // File `con` contains my connection string
    // `Data Source=localhost;Initial Catalog=blogapp;User Id=sa;Password=@YourPassWord;Integrated Security=True;TrustServerCertificate=true;Trusted_Connection=false`
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (File.Exists(ConnectionStringFilePath))
        {
            string connectionString = File.ReadAllText(ConnectionStringFilePath).Trim();
            // Use the connection string to configure the DbContext
            optionsBuilder.UseSqlServer(connectionString);
        }
        else
        {
            // Handle error: file not found
            throw new InvalidOperationException($"The connection string file '{ConnectionStringFilePath}' does not exist.");
        }
    }
}