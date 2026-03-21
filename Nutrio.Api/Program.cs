
using System.Text.Json.Serialization;

namespace Nutrio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

      
            //конвертацыя енумыв в стрынги при передаче через API
            builder.Services.AddControllers()
             .AddJsonOptions(options =>
              {
                 options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
             });

            app.Run();
        }
    }
}
