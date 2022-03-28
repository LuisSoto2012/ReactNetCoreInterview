using System.Text.Json.Serialization;

namespace InterviewProject.Models
{
    /// <summary>
    /// Represents a location's parent
    /// </summary>
    public class ParentResponse
    {
        /// <summary>
        /// Parent title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Parent Location Type
        /// </summary>
        [JsonPropertyName("location_type")]
        public string LocationType { get; set; }
        
        /// <summary>
        /// Parent Latitude Longitude
        /// </summary>
        [JsonPropertyName("latt_long")]
        public string LattLong { get; set; }

        /// <summary>
        /// Where On Earth ID
        /// </summary>
        [JsonPropertyName("woeid")]
        public int Woeid { get; set; }
    }
}