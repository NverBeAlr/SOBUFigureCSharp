using SOBUFigure.Models;

namespace SOBUFigure.Services.Categories;

public interface ICategoryService
{
    //Lay du lieu danh sach
    Task<List<Category>> GetAllCategoriesAsync();
    //Lay 1 ban ghi theo id
    Task<Category> GetCategoryByIdAsync(int Id);
    //Tao moi ban ghi
    Task CreateCategoryAsync(Category category);
    //Chinh sua ban ghi
    Task UpdateCategoryAsync(Category category);
    //Xoa ban ghi
    Task DeleteCategoryAsync(int Id);
}