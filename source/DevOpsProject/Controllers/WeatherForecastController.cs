﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            _logger.LogInformation("Hello guys , we are Devops teams");

        }


        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {   
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
