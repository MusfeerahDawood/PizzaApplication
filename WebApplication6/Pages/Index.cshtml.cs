using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Model;
using WebApplication6.Services;

namespace WebApplication6.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Pizza> Pizzas { get; private set; }
        public IEnumerable<Pizza> Pizza { get; private set; }

        public JsonPizzaFile PizzaService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonPizzaFile pizzaService)
        {
            _logger = logger;
            PizzaService = pizzaService;    
        }

        public void OnGet()
        {
            Pizza = PizzaService.getPizzaRecord();
        }
    }
}
