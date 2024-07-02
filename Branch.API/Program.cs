using Branch.API.CreateBranch;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();

// Example: Add branch service if needed
// builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddSingleton<IBranchRepository, BranchRepository>();
var app = builder.Build();

// Configure endpoints
app.MapControllers();

// Example: Define additional endpoints
var createBranchEndpoint = new CreateBranchEndpoint(app.Services.GetRequiredService<IBranchRepository>());
createBranchEndpoint.AddRoutes(app);
// app.MapGet("/api/branch/hello", () => "Hello from Branch API!");

app.Run();
