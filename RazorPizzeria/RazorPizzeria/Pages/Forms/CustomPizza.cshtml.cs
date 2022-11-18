using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;
using System.ComponentModel;

namespace RazorPizzeria.Pages.Forms
{

    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 2;
            if (Pizza.Cheese) PizzaPrice += 3;
            if (Pizza.Peperoni) PizzaPrice += 5;
            if (Pizza.Mushroom) PizzaPrice += 2;
            if (Pizza.Tuna) PizzaPrice += 8;
            if (Pizza.Pinapple) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 5;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});

        }
    }
}
