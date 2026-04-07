using SOBUFigure.Models;

namespace SOBUFigure.Services.Admins;

public interface IAdminService
{
    Task<List<Admin>> GetAllAdminsAsync();
    Task<Admin> GetAdminByIdAsync(int Id);
    Task CreateAdminAsync(Admin admin);
    Task UpdateAdminAsync(Admin admin);
    Task DeleteAdminAsync(int Id);
}