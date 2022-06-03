using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DevOpsProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Gelé", "Vivifiant", "Froid", "Cool", "Doux", "Chaud", "Embaumé", "Trop chaud", "Étouffant", "Brûlant"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Hello Teams , we are back , it's our new DevOps Project ");  

        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {   _logger.LogInformation("Trying get weather ");  
             var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {  
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
                

            })
            .ToArray();
        }
        
    }
}
