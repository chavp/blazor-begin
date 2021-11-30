namespace BlazorAppChavp.Data
{
    using System.ComponentModel.DataAnnotations;

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Required(ErrorMessage = "You must set a summary for your Weather Forecast.")] 
        public string Summary { get; set; }
    }
}
