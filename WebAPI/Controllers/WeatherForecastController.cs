using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static string[] Summaries = new[]
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
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        public string GetSummary(int index)
        {
            return Summaries[index];
        }

        [HttpPost]
        public string[] PostSummary(string summary)
        {
            Summaries = Summaries.Append(summary).ToArray();
            return Summaries;
        }

        [HttpDelete]
        public string[] DeleteSummaries(int index)
        {
            var SummariesList = Summaries.ToList();
            SummariesList.RemoveAt(index);
            Summaries = SummariesList.ToArray();
            return Summaries;
        }

        [HttpPut]
        public string[] UpdateSummmaries(int index, string summary)
        {
            Summaries[index] = summary;
            return Summaries;
        }

        [HttpPost]
        public float Qote(float x, float y)
        {
            return x / y;
        }

        [HttpPost]
        public float Prod(float x, float y)
        {
            return x / y;
        }
    }
}
