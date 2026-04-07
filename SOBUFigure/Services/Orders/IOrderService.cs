using SOBUFigure.Models;

namespace SOBUFigure.Services.Orders;

public interface IOrderService
{
    //Lay toan bo
    Task<List<Order>> GetAllOrderssAsync();
    //Lay theo id
    Task<Order> GetOrderByIdAsync(int Id);
    //Tao
    Task CreateOrderAsync(Order order);
    //Sua
    Task UpdateOrderAsync(Order order);
    //Xoa
    Task DeleteOrderAsync(int Id);
}