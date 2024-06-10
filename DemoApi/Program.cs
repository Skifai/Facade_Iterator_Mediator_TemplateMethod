using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IEmployeeManager2, EmployeeManager2>(); // Everytime a new instance
builder.Services.AddScoped<IEmployeeManager2, EmployeeManager2>();
builder.Services.AddSingleton<IEmployeeManager2, EmployeeManager2>(); // Only one instance per application


builder.Services.AddKeyedTransient<ISalePricingStrategy, NullDiscountPricingStrategy>("null");
builder.Services.AddKeyedTransient<ISalePricingStrategy, AbsoluteDiscountOverThresholdStrategy>("absolute");

var app = builder.Build();


app.Services.GetKeyedService<ISalePricingStrategy>("absolute");

using var scope = app.Services.CreateScope();
{
    var a = scope.ServiceProvider.GetService<IEmployeeManager2>();
    var b = scope.ServiceProvider.GetService<IEmployeeManager2>();
    var x = a == b; // true
}

using var scope2 = app.Services.CreateScope();
{
    scope.ServiceProvider.GetService<IEmployeeManager2>();

}


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", (HttpContext ctx) =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
