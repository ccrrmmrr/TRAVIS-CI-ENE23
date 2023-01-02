var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

var port = Environment.GetEnvironmentVariable("PORT")??"8080";

app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "GET - Net 6 Running ... 01012023-v1.0.0 CI/CD in TRAVVIS v1.0.1 AFORO255";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "POST - Net 6 Running ... 01012023-v1.0.0 CI/CD in TRAVIS v1.0.1 AFORO255";
});

app.Run($"http://0.0.0.0:{port}");

