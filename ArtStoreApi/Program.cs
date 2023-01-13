using ArtStoreApi.Models;
using ArtStoreApi.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//tells artstoredatabasesettings totake porperties from artstoredatabase properties in appsettings.json
builder.Services.Configure<ArtStoreDatabaseSettings>(
    builder.Configuration.GetSection("ArtStoreDatabase"));

builder.Services.AddSingleton<ArtService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
