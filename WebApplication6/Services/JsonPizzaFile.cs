using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Model;
using System.Text.Json;

namespace WebApplication6.Services

{
    public class JsonPizzaFile  
        {
        private object fileStream;
    

    public IWebHostEnvironment WebHostEnvironment { get; set; }

    public JsonPizzaFile(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    public string fileAddress
    {
        get
        {
            return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Pizza.json");
        }
    }

        public IWebHostEnvironment WebHostEnvirnment { get; }

        public IEnumerable<Pizza> getPizzaRecord()
    {
        using (var fileStream = File.OpenText(fileAddress))
        {
            return JsonSerializer.Deserialize<Pizza[]>(fileStream.ReadToEnd());
        }
    }
}
    
        

         
}


