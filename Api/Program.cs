using GateFlowDashboardAPI.BusinessLogic.Contract;
using GateFlowDashboardAPI.BusinessLogic.Implementations;
using GateFlowDashboardAPI.DataAccess.IRepository;
using GateFlowDashboardAPI.DataAccess.Repository;
using GateFlowDashboardAPI.EFCore;
using GateFlowDashboardAPI.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GateFlowDashboardAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers(c => c.Filters.Add<GlobalExceptionFilter>());
            builder.Services.AddDbContext<ApiContext>(x => x.UseInMemoryDatabase("MyDatabase"));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddLogging(x =>
            {
                x.ClearProviders();
                x.AddConsole();
            });

            //Swagger xml Comments
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            builder.Services.AddSwaggerGen(a => a.IncludeXmlComments(xmlPath));

            builder.Services.AddScoped<IGateFlow, GateFlow>();
            builder.Services.AddScoped<ISensorEventRepository, SensorEventRepository>();

            var app = builder.Build();
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
        }
    }
}