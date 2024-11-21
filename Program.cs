var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files
app.UseStaticFiles();

// Set the default file to load
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
