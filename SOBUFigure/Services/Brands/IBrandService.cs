using SOBUFigure.Models;

namespace SOBUFigure.Services.Brands;

public interface IBrandService
{
    //Lay du lieu danh sach
    Task<List<Brand>> GetAllBrandsAsync();
    //Lay 1 ban ghi theo id
    Task<Brand> GetCategoryByIdAsync(int Id);
    //Tao moi ban ghi
    Task CreateBrandAsync(Brand brand);
    //Chinh sua ban ghi
    Task UpdateBrandAsync(Brand brand);
    //Xoa ban ghi
    Task DeleteBrandAsync(int Id);
}