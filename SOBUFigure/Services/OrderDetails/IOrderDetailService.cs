using SOBUFigure.Models;

namespace SOBUFigure.Services.OrderDetails;

public interface IOrderDetailService
{
    Task<List<OrderDetail>> GetOrderDetailsByOrderIdAsync(int orderId);
    Task AddOrderDetailAsync(OrderDetail orderDetail);
    Task DeleteOrderDetailAsync(int id);
}