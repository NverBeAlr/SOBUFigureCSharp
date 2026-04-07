using SOBUFigure.Models;

namespace SOBUFigure.Services.OrderDetails;

public interface IOrderDetailService
{
    Task<List<OrderDetail>> GetAllOrderDetailsAsync();
    Task<OrderDetail> GetOrderDetailByIdAsync(int Id);
    Task<OrderDetail> CreateOrderDetailAsync(OrderDetail orderDetail);
    Task<OrderDetail> UpdateOrderDetailAsync(OrderDetail orderDetail);
    Task DeleteOrderDetailAsync(int Id);
}