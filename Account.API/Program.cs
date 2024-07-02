using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();

// Example: Add account service if needed
// builder.Services.AddScoped<IAccountService, AccountService>();

var app = builder.Build();

// Configure endpoints
app.MapControllers();

// Example: Define additional endpoints
// app.MapGet("/api/account/hello", () => "Hello from Account API!");

app.Run();



