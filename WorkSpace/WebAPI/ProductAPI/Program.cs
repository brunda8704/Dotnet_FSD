using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using ProductAPI.DBContext;
using ProductAPI.Repository;
using System.Reflection;

namespace ProductAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //register the validators

            builder.Services.AddControllers()
                .AddFluentValidation(configuration=>
                {
                    configuration.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //database connection   

            builder.Services.AddDbContext<ProductDBContext>(options => options.
            UseSqlServer(builder.Configuration.GetConnectionString("ProductConnectionString")));

            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}