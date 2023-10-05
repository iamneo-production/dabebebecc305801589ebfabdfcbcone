using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Configuration.AddJsonFile("Ocelot.json");
builder.Services.AddOcelot(builder.Configuration);

app.MapGet("/", () => "Hello World!");


app.MapControllers();
await app.UseOcelot();
app.Run();
