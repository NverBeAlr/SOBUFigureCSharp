using Microsoft.EntityFrameworkCore;
using SOBUFigure.Data;
using SOBUFigure.Models;

namespace SOBUFigure.Services.Admins;

public class AdminService : IAdminService
{
    private readonly AppDbContext _context;
    
    public AdminService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Admin>> GetAllAdminsAsync()
    {
        return await _context.Admins.ToListAsync();
    }

    public async Task<Admin> GetAdminByIdAsync(int Id)
    {
        return await _context.Admins.FindAsync(Id);
    }

    public async Task CreateAdminAsync(Admin admin)
    {
        _context.Admins.Add(admin);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAdminAsync(Admin admin)
    {
        _context.Admins.Update(admin);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAdminAsync(int Id)
    {
        Admin admin = await _context.Admins.FindAsync(Id);
        _context.Admins.Remove(admin);
        await _context.SaveChangesAsync();
    }
}