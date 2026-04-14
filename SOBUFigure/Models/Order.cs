using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOBUFigure.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    
    public int CustomerId { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public int Status { get; set; }
    
    [ForeignKey("CustomerId")]
    public Customer? customer { get; set; }
}