
var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();

// Example: Add branch service if needed
// builder.Services.AddScoped<IBranchService, BranchService>();

var app = builder.Build();

// Configure endpoints
app.MapControllers();

// Example: Define additional endpoints
// app.MapGet("/api/branch/hello", () => "Hello from Branch API!");

app.Run();

