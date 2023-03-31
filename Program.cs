var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, from AWS Summit Paris 2023!");

app.Run();
