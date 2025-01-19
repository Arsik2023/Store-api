using System.ComponentModel.DataAnnotations.Schema;

namespace Api;

public class ShoppingCart
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public ICollection<CartItem> CartItems { get; set; }

    [NotMapped]
    public double TotalAmount { get; set; }
}
