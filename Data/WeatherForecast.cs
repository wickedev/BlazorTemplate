namespace BlazorTemplate.Data;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("weather_forecasts")]
public class WeatherForecast
{
    public int Id { get; set; }

    [Required]
    public DateTime DateTimeAt { get; set; }

    [Required]
    public int TemperatureC { get; set; }

    [NotMapped]
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    [Column("summary")]
    public string? Summary { get; set; }
}
