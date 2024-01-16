using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pizza_Proj.Pages
{
    public class PizzaSelectionModel : PageModel
    {
        [BindProperty]
        public string? SelectedPizzaType { get; set; }

        [BindProperty]
        public int Quantity { get; set; }

        public List<SelectListItem> PizzaTypes { get; } = new List<SelectListItem>
    {
        new SelectListItem("Margherita", "Margherita"),
        new SelectListItem("Pepperoni", "Pepperoni"),
        new SelectListItem("Vegetarian", "Vegetarian")
    };

        public IActionResult OnPostAddToCart()
        {
            // Handle adding the selected pizza to the cart
            // You may want to store the selection in a session or a database
            return RedirectToPage("./OrderCheckout");
        }
    }
}
