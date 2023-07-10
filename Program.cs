using GateFlowDashboardAPI.BusinessLogic.Implementations;
using GateFlowDashboardAPI.BusinessLogic.Contract;
using GateFlowDashboardAPI.EFCore;
using Microsoft.EntityFrameworkCore;
using GateFlowDashboardAPI.DataAccess.IRepository;
using GateFlowDashboardAPI.DataAccess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiContext>(x => x.UseInMemoryDatabase("MyDatabase"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGateFlow, GateFlow>();
builder.Services.AddScoped<ISensorEventRepository,SensorEventRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
}

//Seed DataLogic
using var service = app.Services.CreateScope();
var context = service.ServiceProvider.GetRequiredService<ApiContext>();
var seedGenerator = new SeedGenerator();
seedGenerator.SeedData(context);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();