using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DemoAP API", Version = "v1" });
});

var app = builder.Build();

// Configure middleware pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Enable Swagger UI for API testing.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "DemoAP API v1");
        c.RoutePrefix = string.Empty; // Swagger available at root URL
    });
}

app.Run();