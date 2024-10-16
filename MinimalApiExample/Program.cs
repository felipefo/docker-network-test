var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "8080");

app.Run();
