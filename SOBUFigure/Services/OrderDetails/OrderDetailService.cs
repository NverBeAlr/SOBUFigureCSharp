using Microsoft.EntityFrameworkCore;
using SOBUFigure.Data;
using SOBUFigure.Models;

namespace SOBUFigure.Services.OrderDetails;

public class OrderDetailService : IOrderDetailService
{
    
    public Task<List<OrderDetail>> GetAllOrderDetailsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderDetail> GetOrderDetailByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDetail> CreateOrderDetailAsync(OrderDetail orderDetail)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDetail> UpdateOrderDetailAsync(OrderDetail orderDetail)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrderDetailAsync(int Id)
    {
        throw new NotImplementedException();
    }
}