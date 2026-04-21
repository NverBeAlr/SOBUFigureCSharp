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

    public async Task<List<OrderDetail>> GetOrderDetailsByOrderIdAsync(int orderId)
    {
        return await _context.OrderDetails
            .Include(x => x.Figure)
            .Where(x => x.OrderId == orderId)
            .ToListAsync();
    }

    public async Task AddOrderDetailAsync(OrderDetail orderDetail)
    {
        _context.OrderDetails.Add(orderDetail);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteOrderDetailAsync(int id)
    {
        var detail = await _context.OrderDetails.FindAsync(id);

        if (detail != null)
        {
            _context.OrderDetails.Remove(detail);
            await _context.SaveChangesAsync();
        }
    }
}