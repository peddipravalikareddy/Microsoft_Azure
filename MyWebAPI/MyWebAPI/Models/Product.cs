//using Microsoft.EntityFrameworkCore;
//using MyWebAPI.Data;

//namespace MyWebAPI.Models
//{
//    public class Product
//    {
//    }
//}
using Microsoft.EntityFrameworkCore;
using MyWebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add database context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyWebAPI v1");
    c.RoutePrefix = string.Empty; // Swagger available at root URL
});

app.Run();