using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizza_Proj.Pages
{
    public class OrderConfirmationModel : PageModel
    {
        public string OrderId { get; set; } = "12345"; // Replace with actual order ID
        public decimal Amount { get; set; } // Populate from the order details
        public string? PizzaType { get; set; } // Populate from the order details
    }
}
