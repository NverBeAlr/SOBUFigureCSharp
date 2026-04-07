using System.ComponentModel.DataAnnotations;

namespace SOBUFigure.Models;

public class Customer
{
    [Key]
    public int Id { get; set; }
    
    [Required (ErrorMessage = "Không được để trống")]
    public String Name { get; set; }
    
    [Required (ErrorMessage = "Không được để trống")]
    public String Email { get; set; }
    
    [Required (ErrorMessage = "Không được để trống")]
    public int Phone_number { get; set; }
    
    [Required (ErrorMessage = "Không được để trống")]
    public String Password { get; set; }
    
    [Required (ErrorMessage = "Không được để trống")]
    public String Address { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}