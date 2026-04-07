using Microsoft.EntityFrameworkCore;
using SOBUFigure.Data;
using SOBUFigure.Models;

namespace SOBUFigure.Services.Figures;

public class FigureService : IFigureService
{
    private readonly AppDbContext _context;
    
    public FigureService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Figure>> GetAllFiguresAsync()
    {
        return await  _context.Figures.Include(f => f.category).Include(f => f.brand).ToListAsync();
    }

    public async Task<Figure> GetFigureByIdAsync(int Id)
    {
        return await _context.Figures.FindAsync(Id);
    }

    public async Task CreateFigureAsync(Figure figure)
    {
        _context.Figures.Add(figure);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateFigureAsync(Figure figure)
    {
        _context.Figures.Update(figure);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteFigureAsync(int Id)
    {
        var figure = await GetFigureByIdAsync(Id);
        _context.Figures.Remove(figure);
        await _context.SaveChangesAsync();
    }
}