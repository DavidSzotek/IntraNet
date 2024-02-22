using Microsoft.EntityFrameworkCore;
using WebApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Work"));
}, ServiceLifetime.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();



app.UseCors(options => options
.WithOrigins(new[] { "http://localhost:3000", "http://10.188.50.66:3000" })
.AllowAnyHeader()
.AllowAnyMethod()
.AllowCredentials()
);



app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
