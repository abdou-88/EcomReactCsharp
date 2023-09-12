using Microsoft.AspNetCore.Mvc;

namespace EcomReactCsharp.Controllers{


    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
    

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
               
            })
            .ToArray();
        }
    }

}
