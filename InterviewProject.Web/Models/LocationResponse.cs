using System;
using System.Text.Json.Serialization;

namespace InterviewProject.Models
{
    /// <summary>
    /// Represents a Location
    /// </summary>
    public class LocationResponse
    {
        /// <summary>
        /// Location title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Location Type
        /// </summary>
        [JsonPropertyName("location_type")]
        public string LocationType { get; set; }
        
        /// <summary>
        /// Location Latitude Longitude
        /// </summary>
        [JsonPropertyName("latt_long")]
        public string LattLong { get; set; }

        /// <summary>
        /// Location Time
        /// </summary>
        [JsonPropertyName("time")]
        public DateTime Time { get; set; }
        
        /// <summary>
        /// Location Sun Rise
        /// </summary>
        [JsonPropertyName("sun_rise")]
        public DateTime SunRise { get; set; }
        
        /// <summary>
        /// Location Sun Set
        /// </summary>
        [JsonPropertyName("sun_set")]
        public DateTime SunSet { get; set; }
        
        /// <summary>
        /// Location TimeZone
        /// </summary>
        [JsonPropertyName("timezone_name")]
        public string TimeZoneName { get; set; }
        
        /// <summary>
        /// Location Parent
        /// </summary>
        [JsonPropertyName("parent")]
        public ParentResponse Parent { get; set; }
        
        /// <summary>
        /// Location Consolidated Weather
        /// </summary>
        [JsonPropertyName("consolidated_weather")]
        public WeatherResponse[] ConsolidatedWeather { get; set; }
        
        /// <summary>
        /// Location Sources
        /// </summary>
        [JsonPropertyName("sources")]
        public SourceResponse[] Sources { get; set; }
    }
}