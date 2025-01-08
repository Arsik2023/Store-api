using System.ComponentModel.DataAnnotations;

namespace Api;

public class Product
/* Основные поля для товара */
{
    [Key] // Id - ключ
    public int Id { get; set; }
    [Required] // NOT NULL
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public string SpecialTag { get; set; }
    public string Category { get; set; }
    [Range(1, 1000)] // мин/макс прайс продукта
    public double Price { get; set; }
    public string Image { get; set; }
}
