using Microsoft.EntityFrameworkCore;
using SOBUFigure.Data;
using SOBUFigure.Models;

namespace SOBUFigure.Services.Orders;

public class OrderService : IOrderService
{
    private readonly AppDbContext _context;
    
    public OrderService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Order>> GetAllOrderssAsync()
    {
        return await _context.Orders.Include(o => o.customer).ToListAsync();
    }

    public async Task<Order> GetOrderByIdAsync(int Id)
    {
        return await _context.Orders.FindAsync(Id);
    }

    public async Task CreateOrderAsync(Order order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateOrderAsync(Order order)
    {
        _context.Orders.Update(order);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteOrderAsync(int Id)
    {
        var order = await GetOrderByIdAsync(Id);
        _context.Orders.Remove(order);
        await _context.SaveChangesAsync();
    }
}