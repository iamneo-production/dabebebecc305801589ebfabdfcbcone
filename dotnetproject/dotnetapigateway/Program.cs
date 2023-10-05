using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Configuration.AddJsonFile("Ocelot.json",optional:false,reloadOnChange:true);
builder.Services.AddOcelot(builder.Configuration);

app.MapGet("/", () => "Hello World!");


app.MapControllers();
await app.UseOcelot();
app.Run();
