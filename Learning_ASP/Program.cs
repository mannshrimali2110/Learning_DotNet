using Learning_ASP.Data;
using Learning_ASP.Entities;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGameEndpoints();

app.MigrateDB();
app.Run();
