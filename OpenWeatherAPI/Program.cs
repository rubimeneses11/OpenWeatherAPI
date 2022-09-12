using Newtonsoft.Json.Linq;
using OpenWeatherAPI;

string key = File.ReadAllText("appsettings.json");

//store API key as a variable
string APIkey = JObject.Parse(key).GetValue("APIkey").ToString();



//prompting user for input
Console.WriteLine($"Please enter your zipcode");
//storing zipcode as a variable
var zipCode = Console.ReadLine();


//calling weather API
var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";

//to separate space
Console.WriteLine();


//RESULT:
Console.WriteLine($"It is currently {WeatherMap.GetTemp(weatherURL)} degrees F in your location.");
