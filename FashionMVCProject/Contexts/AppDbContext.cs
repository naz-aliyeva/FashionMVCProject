using FashionMVCProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FashionMVCProject.Contexts;

public class FeaturedProductService : DbContext
{
    private readonly string _connectionString = @"Server=;Database=FashionMVCProject;Trusted_Connection=True; TrustServerCertificate=True";
    public DbSet<FeaturedProducts> FeaturedProducts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    internal void CreateFeaturedProducts(FeaturedProducts featured)
    {
        throw new NotImplementedException();
    }

    internal void DeleteFeaturedProducts(int id)
    {
        throw new NotImplementedException();
    }

    internal List<FeaturedProducts> GetAllFeaturedProducts()
    {
        throw new NotImplementedException();
    }

    internal FeaturedProducts GetFeaturedProductsById(int id)
    {
        throw new NotImplementedException();
    }
}
