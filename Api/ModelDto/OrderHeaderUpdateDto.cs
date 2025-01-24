using System.ComponentModel.DataAnnotations;

namespace Api;

public class OrderHeaderUpdateDto
{
    public int OrderHeaderId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string Status { get; set; }
}
