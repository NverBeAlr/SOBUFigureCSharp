using Microsoft.EntityFrameworkCore;
using SOBUFigure.Data;

namespace SOBUFigure.Services.Admins;

public class AuthService : IAuthService
{
    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> ValidateAdminAuthAsync(string email, string password)
    {
        var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Email == email);

        if (admin == null)
        {
            return false;
        }   

        bool isValidPassword = BCrypt.Net.BCrypt.Verify(password, admin.Password);
        return isValidPassword;
    }
}