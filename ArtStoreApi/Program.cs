using ArtStoreApi.Models;
using ArtStoreApi.Services;
//enable cors so frontend app can pull
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder for CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                        //   policy.WithOrigins("http://localhost:3000")
                          policy.WithOrigins("https://dotnetheadache.netlify.app/")

                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                      });
});

//tells artstoredatabasesettings totake porperties from artstoredatabase properties in appsettings.json
builder.Services.Configure<ArtStoreDatabaseSettings>(
    builder.Configuration.GetSection("ArtStoreDatabase"));

//BooksService class is registered w/ DI to support constructor injection in consuming classes
builder.Services.AddSingleton<ArtService>();


//
builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
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
//not sure i need this

app.UseRouting();


//for cors requests
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
