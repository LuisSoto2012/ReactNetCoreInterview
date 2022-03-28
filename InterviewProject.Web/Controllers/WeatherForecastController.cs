using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using InterviewProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InterviewProject.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private HttpClient client;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }
        
        private async Task<string> QueryAPI(string query)
        {
            HttpResponseMessage response = await client.GetAsync(query);
            HttpStatusCode statusCode = response.StatusCode;

            if (statusCode == HttpStatusCode.OK)
            {
                string asString = await response.Content.ReadAsStringAsync();
                return asString;
            }
            
            return null;
        }

        /// <summary>
        /// Get Where on earth Id from the MetaWeatherAPI by Location
        /// </summary>
        /// <returns>Where on earth Id by location (woeid)</returns>
        [HttpGet("GetWoeid")]
        public async Task<IEnumerable<LocationSearchResponse>> GetWoeid([FromQuery]string location)
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("https://www.metaweather.com/api/")
            };

            var response = await QueryAPI($"location/search/?query={location}");
            LocationSearchResponse[] foundLocation = JsonSerializer.Deserialize<LocationSearchResponse[]>(response);
            if (response == null)
                return new List<LocationSearchResponse>();

            return foundLocation;
        }
        
        /// <summary>
        /// Get the weather forecasts from the MetaWeatherAPI by Location
        /// </summary>
        /// <returns>A list of weather forecasts by location (woeid)</returns>
        [HttpGet("{woeid:int}")]
        public async Task<LocationResponse> GetAsync(int woeid)
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("https://www.metaweather.com/api/")
            };

            // string response = await QueryAPI("location/search/?query=belfast");
            // Location[] foundLocation = JsonSerializer.Deserialize<Location[]>(response);
            // if (response == null)
            //     return new List<Forecast>();

            // string response = await QueryAPI($"location/{foundLocation[0].WhereOnEarthId}/");
            string response = await QueryAPI($"location/{woeid}/");
            if (response == null)
                return new LocationResponse();

            LocationResponse locationResponse = JsonSerializer.Deserialize<LocationResponse>(response);

            return locationResponse;
        }
    }
}
