using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel() { ImageTitle="Margerita", PizzaName="Margerita", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=13},
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=22},
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=15},
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=18},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=33},
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=20},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=25},
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=30},
            new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=5, TomatoSauce=true, Cheese=true,FinalPrice=20}
        };
        public void OnGet()
        {
        }
    }
}
