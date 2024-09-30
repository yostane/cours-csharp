var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Hero> heroes = [
  new() { Id = 1, Name = "garan", Role = Role.Fighter },
  new() { Id = 2, Name = "saraka", Role = Role.Spport },
];

app.MapGet("/heroes", () => heroes);
app.MapGet("/", () => "Hello World!");

app.Run();
