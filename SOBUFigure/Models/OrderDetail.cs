using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOBUFigure.Models;

public class OrderDetail
{
    [Key]
    public int Id { get; set; }
    
    public int OrderId { get; set; }
    
    public int FigureId { get; set; }
    
    [Required(ErrorMessage = "Không được để trống")]
    public int Quantity { get; set; }
    
    [Required(ErrorMessage = "Không được để trống")]
    public double TotalPrice { get; set; }
    
    [ForeignKey("OrderId")]
    public Order? Order { get; set; }
    [ForeignKey("FigureId")]
    public Figure? Figure { get; set; }
}