using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebApplication6.Model;
using WebApplication6.Services;

namespace PizzaApplication.Pages
{
    public class PizzaListModel : PageModel
    {
        JsonPizzaFile PizzaService;
       public IEnumerable<Pizza> Pizza;

        public PizzaListModel(JsonPizzaFile PizzaService)
        {
            this.PizzaService = PizzaService;   
        }
        public void OnGet()
        {
            Pizza = PizzaService.getPizzaRecord();

        }
    }
}
