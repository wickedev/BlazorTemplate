namespace BlazorTemplate.Data;

using Microsoft.EntityFrameworkCore;

public class WeatherForecastService
{
    private AppDataContext AppDataContext;
    private DbSet<WeatherForecast> WeatherForecasts;

    public WeatherForecastService(AppDataContext AppDataContext)
    {
        this.AppDataContext = AppDataContext;
        this.WeatherForecasts = AppDataContext.WeatherForecasts;
    }

    public Task<List<WeatherForecast>> GetForecastAsync(DateOnly startDate)
    {
        return WeatherForecasts.OrderByDescending(i => i.Id).ToListAsync();
    }

    public async Task<WeatherForecast> CreateForecastAsync(WeatherForecast weatherForecast)
    {
        var entity = await WeatherForecasts.AddAsync(weatherForecast);
        await AppDataContext.SaveChangesAsync();
        return entity.Entity;
    }

    public async Task<int> UpdateForecastAsync(WeatherForecast weatherForecast)
    {
        WeatherForecasts.Attach(weatherForecast);
        return await AppDataContext.SaveChangesAsync();
    }

    public Task<int> DeleteForecastAsync(int id)
    {
        return WeatherForecasts
           .Where(wf => wf.Id == id)
           .ExecuteDeleteAsync();
    }
}
