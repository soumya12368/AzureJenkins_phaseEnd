using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizza_Proj.Pages
{
    public class OrderItem
    {
        public string? PizzaType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class OrderCheckoutModel : PageModel
    {
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public decimal TotalAmount => OrderItems.Sum(item => item.Price);

        public void OnGet()
        {
            // Populate OrderItems from the cart or session
        }
    }
}
