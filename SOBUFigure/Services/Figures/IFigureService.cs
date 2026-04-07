using SOBUFigure.Models;

namespace SOBUFigure.Services.Figures;

public interface IFigureService
{
    //Lay toan bo
    Task<List<Figure>> GetAllFiguresAsync();
    //Lay theo id
    Task<Figure> GetFigureByIdAsync(int Id);
    //Tao
    Task CreateFigureAsync(Figure figure);
    //Sua
    Task UpdateFigureAsync(Figure figure);
    //Xoa
    Task DeleteFigureAsync(int Id);
}