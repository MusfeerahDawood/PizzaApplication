using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication6.Model;
using WebApplication6.Services;

namespace PizzaApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        JsonPizzaFile PizzaService { get; }
        public PizzaController(JsonPizzaFile PizzaService)
        {
            this.PizzaService = PizzaService; 
        }
        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
          return  PizzaService.getPizzaRecord();
        }
    }
}
