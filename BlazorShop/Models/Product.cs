using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o título")]
    [MinLength(3, ErrorMessage = "O titúlo deve ter no mínimo 3 caracteres")]
    [MaxLength(120, ErrorMessage = "O título deve ter no máximo 120 caracteres")]
    public string Title { get; set; } = String.Empty;
    
    public string? Description { get; set; }
    
    [Required(ErrorMessage = "Informe o preço do Produto")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}