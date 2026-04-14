using SOBUFigure.Models;

namespace SOBUFigure.Services.Admins;

public interface IAuthService
{
    Task<bool> ValidateAdminAuthAsync(string Email, string password);
}