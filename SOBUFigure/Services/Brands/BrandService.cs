using Microsoft.EntityFrameworkCore;
using SOBUFigure.Data;
using SOBUFigure.Models;

namespace SOBUFigure.Services.Brands;

public class BrandService : IBrandService
{
    private readonly AppDbContext _context;
    
    public BrandService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Brand>> GetAllBrandsAsync()
    {
        return await _context.Brands.ToListAsync();
    }

    public async Task<Brand> GetCategoryByIdAsync(int Id)
    {
        return await _context.Brands.FindAsync(Id);
    }

    public async Task CreateBrandAsync(Brand brand)
    {
        _context.Brands.Add(brand);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateBrandAsync(Brand brand)
    {
        _context.Brands.Update(brand);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteBrandAsync(int Id)
    {
        Brand brand =  await _context.Brands.FindAsync(Id);
        _context.Brands.Remove(brand);
        await _context.SaveChangesAsync();
    }
}