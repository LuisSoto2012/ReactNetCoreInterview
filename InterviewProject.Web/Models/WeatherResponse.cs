using System;
using System.Text.Json.Serialization;

namespace InterviewProject.Models
{
    /// <summary>
    /// Represents a location's consolidated wearter
    /// </summary>
    public class WeatherResponse
    {
        /// <summary>
        /// Weather Id
        /// </summary>
        [JsonPropertyName("id")]
        public Int64 Id { get; set; }

        /// <summary>
        /// Weather Applicable Date
        /// </summary>
        [JsonPropertyName("applicable_date")]
        public DateTime ApplicableDate { get; set; }
        
        /// <summary>
        /// Weather State Name
        /// </summary>
        [JsonPropertyName("weather_state_name")]
        public string WeatherStateName { get; set; }
        
        /// <summary>
        /// Weather State Abbreviation
        /// </summary>
        [JsonPropertyName("weather_state_abbr")]
        public string WeatherStateAbbr { get; set; }
        
        /// <summary>
        /// Weather Wind Speed
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public float WindSpeed { get; set; }
        
        /// <summary>
        /// Weather Wind Direction
        /// </summary>
        [JsonPropertyName("wind_direction")]
        public float WeatherWindDirection { get; set; }
        
        /// <summary>
        /// Weather Wind direction Compass
        /// </summary>
        [JsonPropertyName("wind_direction_compass")]
        public string WindDirectionCompass { get; set; }
        
        /// <summary>
        /// Weather Min Temp
        /// </summary>
        [JsonPropertyName("min_temp")]
        public float MinTemp { get; set; }
        
        /// <summary>
        /// Weather Max Temp
        /// </summary>
        [JsonPropertyName("max_temp")]
        public float MaxTemp { get; set; }
        
        /// <summary>
        /// Weather The Temp
        /// </summary>
        [JsonPropertyName("the_temp")]
        public float TheTemp { get; set; }
        
        /// <summary>
        /// Weather Air Pressure
        /// </summary>
        [JsonPropertyName("air_pressure")]
        public float AirPressure { get; set; }
        
        /// <summary>
        /// Weather Humidity
        /// </summary>
        [JsonPropertyName("humidity")]
        public float Humidity { get; set; }
        
        /// <summary>
        /// Weather Visibility
        /// </summary>
        [JsonPropertyName("visibility")]
        public float Visibility { get; set; }
        
        /// <summary>
        /// Weather Predictability
        /// </summary>
        [JsonPropertyName("predictability")]
        public Int32 Predictability { get; set; }
    }
}