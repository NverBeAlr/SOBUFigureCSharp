using SOBUFigure.Models;

namespace SOBUFigure.Services.Customers;

public interface ICustomerService
{
    //Lay du lieu danh sach
    Task<List<Customer>> GetAllCustomersAsync();
    //Lay 1 ban ghi theo id
    Task<Customer> GetCustomerByIdAsync(int Id);
    //Tao moi ban ghi
    Task CreateCustomerAsync(Customer customer);
    //Chinh sua ban ghi
    Task UpdateCustomerAsync(Customer customer);
    //Xoa ban ghi
    Task DeleteCustomerAsync(int Id);
}