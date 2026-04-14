using Microsoft.EntityFrameworkCore;
using SOBUFigure.Data;
using SOBUFigure.Models;

namespace SOBUFigure.Services.OrderDetails;

public class OrderDetailService : IOrderDetailService
{
    private readonly AppDbContext _context;

    public OrderDetailService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<OrderDetail>> GetAllOrderDetailsAsync()
    {
        return await _context.OrderDetails.Include(o=>o.Order).Include(o=>o.Figure).ToListAsync();
    }

    public async Task<OrderDetail> GetOrderDetailByIdAsync(int Id)
    {
        return await _context.OrderDetails.FindAsync(Id);
    }

    public async Task CreateOrderDetailAsync(OrderDetail orderDetail)
    {
        _context.OrderDetails.Add(orderDetail);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateOrderDetailAsync(OrderDetail orderDetail)
    {
        _context.OrderDetails.Update(orderDetail);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteOrderDetailAsync(int Id)
    {
        var orderDetail = await GetOrderDetailByIdAsync(Id);
        _context.OrderDetails.Remove(orderDetail);
        await _context.SaveChangesAsync();
    }
}