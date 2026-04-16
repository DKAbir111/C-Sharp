var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Server is running...";
});

app.MapGet("/hello", () =>
{
    return "Hello World!";
});

app.Run();

