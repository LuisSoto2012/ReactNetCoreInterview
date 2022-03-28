using System;
using System.Text.Json.Serialization;

namespace InterviewProject.Models
{
    /// <summary>
    /// Represents a Location
    /// </summary>  
    public class LocationSearchResponse
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
        /// Location Where on earth Id
        /// </summary>
        [JsonPropertyName("woeid")]
        public Int64 Woeid { get; set; }
        
    }
}