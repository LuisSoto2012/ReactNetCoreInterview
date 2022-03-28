using System.Text.Json.Serialization;

namespace InterviewProject.Models
{
    /// <summary>
    /// Represents a location's source
    /// </summary>
    public class SourceResponse
    {
        /// <summary>
        /// Source title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Source url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}