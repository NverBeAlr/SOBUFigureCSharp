using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOBUFigure.Models;

public class Figure
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Không được để trống")]
    public string Name { get; set; }
    
    public int CategoryId { get; set; }
    
    public int BrandId { get; set; }
    
    [Required(ErrorMessage = "Không được để trống")]
    public double Price { get; set; }
    
    [Required(ErrorMessage = "Không được để trống")]
    public int Quantity { get; set; }
    
    [Required(ErrorMessage = "Không được để trống")]
    public String Scale { get; set; }
    
    public string Description { get; set; }
    
    [ForeignKey("CategoryId")]
    public Category? category { get; set; }
    
    [ForeignKey("BrandId")]
    public Brand? brand { get; set; }
}