using FashionMVCProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FashionMVCProject.Contexts;

public class AppDbContext : DbContext
{
    private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=FashionMVCProject;Trusted_Connection=True; TrustServerCertificate=True";
    public DbSet<FeaturedProducts> FeaturedProducts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }

}
