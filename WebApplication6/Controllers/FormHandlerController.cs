using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using WebApplication6.Model;
using WebApplication6.Services;

namespace PizzaApplication.Controllers
{
   
    
        [Route("[Controller]")]
        
    public class FormHandlerController : Controller
        {
            JsonPizzaFile PizzaService;
            public FormHandlerController(JsonPizzaFile PizzaService)
            {
                this.PizzaService = PizzaService;
            }
            [HttpGet]
          public string Get(int id,string name,string image)
            {
                Pizza obj = new Pizza();
                obj.Pizza_id = id;
                obj.name = name;
                obj.image = image;

              IEnumerable<Pizza>PizzaData=  PizzaService.getPizzaRecord();
              List<Pizza>ListofPizza=  PizzaData.ToList();
                ListofPizza.Add(obj);

           return JsonSerializer.Serialize<List<Pizza>>(ListofPizza);

                

            }
        }
    }

