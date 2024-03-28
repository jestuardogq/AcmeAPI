using AcmeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AcmeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public Dictionary<string, string> Post([FromServices] IPruebaService pruebaService)
        {
            Dictionary<string, string> myMap = new Dictionary<string, string>();
            
            myMap.Add("nombre", "Jeffer");
            myMap.Add("edad", "muchos");
            myMap.Add("suma", "" + pruebaService.Suma(3, 5));
            return myMap;
        }
    }
}
