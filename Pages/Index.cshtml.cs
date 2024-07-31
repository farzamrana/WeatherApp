using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WeatherService _weatherService;

        public IndexModel(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [BindProperty(SupportsGet = true)]
        public string City { get; set; }

        public WeatherData Weather { get; set; }

        public async Task OnGet()
        {
            if (!string.IsNullOrEmpty(City))
            {
                try
                {
                    Weather = await _weatherService.GetWeatherAsync(City);

                    if (Weather == null || Weather.Main == null)
                    {
                        ModelState.AddModelError(string.Empty, "Could not retrieve weather data. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception (not shown here for brevity)
                    ModelState.AddModelError(string.Empty, "An error occurred while fetching weather data.");
                }
            }
        }
    }
}
