using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "a7837510edc0a4d1df3b2e3e79f08f7f";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            try
            {
                var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={_apiKey}");

                // Check if the response is successful
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();

                // Log the raw response for debugging
                Console.WriteLine($"Raw response: {responseBody}");

                // Deserialize the JSON response
                var weatherData = JsonSerializer.Deserialize<WeatherData>(responseBody, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // This allows case-insensitive matching of JSON property names
                });

                // Check if weatherData is null
                if (weatherData == null)
                {
                    throw new Exception("Failed to deserialize weather data.");
                }

                return weatherData;
            }
            catch (HttpRequestException httpEx)
            {
                // Handle HTTP request errors
                Console.WriteLine($"Request error: {httpEx.Message}");
                throw; // Re-throw the exception for further handling if needed
            }
            catch (JsonException jsonEx)
            {
                // Handle JSON deserialization errors
                Console.WriteLine($"JSON deserialization error: {jsonEx.Message}");
                throw; // Re-throw the exception for further handling if needed
            }
            catch (Exception ex)
            {
                // Handle general errors
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw; // Re-throw the exception for further handling if needed
            }
        }
    }
}
