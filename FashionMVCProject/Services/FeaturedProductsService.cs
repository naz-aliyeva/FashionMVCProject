using FashionMVCProject.Contexts;
using FashionMVCProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FashionMVCProject.Services;

public class FeaturedProductsService
{
    private  FeaturedProductService _context;

    public FeaturedProductsService()
    {
        _context = new FeaturedProductService();  

    }
    
    #region Create
    public void CreateFeaturedCar(FeaturedProducts featured)
    {
        _context.FeaturedProducts.Add(featured);
        _context.SaveChanges();
    }
    #endregion


    #region Read

    public FeaturedProducts GetFeaturedProductsById(int id)
    {
        FeaturedProducts? featuredCar = _context.FeaturedProducts.Find(id);
        if (featuredCar is null)
        {
            throw new Exception($"Database daxilinde {id} id-e sahib data tapilmadi");
        }

        return featuredCar;
    }
    public List<FeaturedProducts> GetAllFeaturedProducts()
    {
        List<FeaturedProducts> featuredCars = _context.FeaturedProducts.ToList();
        return featuredCars;
    }
    #endregion

    #region Update
    public void UpdateFeaturedCar(int id, FeaturedProducts updatedFeaturedProduct)
    {
        if (id != updatedFeaturedProduct.Id)
        {
            throw new Exception("id-ler ust uste dusur ");
        }
        FeaturedProducts? baseFeaturedProducts = _context.FeaturedProducts.AsNoTracking().SingleOrDefault(fP=>fP.Id==id);

        if (baseFeaturedProducts is not null)
        {
            throw new Exception($" databasede {id} id-e sahib data tapilmadi ");
        }
        _context.Update(updatedFeaturedProduct);
        _context.SaveChanges();

    #endregion

        #region Delete 
    public void DeleteFeaturedCar(int id)
    {
        FeaturedProducts? featuredProducts = _context.FeaturedProducts.Find(id);
        if (featuredProducts is null)
        {
            throw new Exception($"Database daxilinde {id} id-e sahib data tapilmadi");
        }
        _context.FeaturedProducts.Remove(featuredProducts);
        _context.SaveChanges();
    }
    #endregion
}



