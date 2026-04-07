using System.ComponentModel.DataAnnotations;

namespace SOBUFigure.Models;

public class Brand
{
    [Key]
    public int Id { get; set; }   
    
    [Required (ErrorMessage = "Không được để trống")]
    public String Name { get; set; }
    
    [Required (ErrorMessage = "Không được để trống")]
    public String Country { get; set; }
    
    public ICollection<Figure> Figures { get; set; } = new List<Figure>();
}