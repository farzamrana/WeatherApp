
# WeatherApp

WeatherApp is a web application built with ASP.NET Core Razor Pages that allows users to check current weather conditions for various cities using the OpenWeatherMap API. It features a responsive user interface styled with Bootstrap and includes a splash screen for improved user experience.

## Features

- **City Search**: Enter a city name to get the current weather.
- **Weather Details**: Displays temperature, weather description, humidity, and wind speed.
- **Splash Screen**: A loading screen to enhance user experience during initial load.

## Getting Started

### Prerequisites

- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- An API key from [OpenWeatherMap](https://openweathermap.org/)

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/your-username/WeatherApp.git
   cd WeatherApp

    Install Dependencies

    Restore the required NuGet packages:

    bash

dotnet restore

Configure API Key

Replace YOUR_API_KEY in WeatherService.cs with your OpenWeatherMap API key:

csharp

    private readonly string _apiKey = "YOUR_API_KEY"; // Replace with your OpenWeatherMap API key

Running the Application

    Build and Run

    You can build and run the application using Visual Studio or the .NET CLI:

    bash

    dotnet build
    dotnet run

    Open the Application

    Navigate to https://localhost:5001 (or the URL provided in your terminal) in your web browser.

Project Structure

    Pages/: Contains Razor Pages and their code-behind files.
    Models/: Contains the data models used for parsing weather data.
    Services/: Contains the service for interacting with the OpenWeatherMap API.
    wwwroot/: Static files like CSS and images.
    _Layout.cshtml: Main layout page that includes the splash screen.

Contributing

Feel free to fork the repository and submit pull requests. For major changes, please open an issue first to discuss what you would like to change.
License

This project is licensed under the MIT License - see the LICENSE file for details.
Contact

For any questions or issues, please contact farzamranahosseini@yahoo.com.

vbnet


### Instructions for Using the README

- **Replace Placeholder Text**: Make sure to replace `"YOUR_API_KEY"` with your actual OpenWeatherMap API key and update the GitHub URL and email address with your own details.
- **Include License**: If you have a specific license for your project, include a `LICENSE` file in the repository.

You can copy and paste this `README.md` content into your GitHub repository’s `README.md` file to provide users with clear instructions and information about your WeatherApp.


