using Microsoft.EntityFrameworkCore;
using StudentAPI.DBContext;
using StudentAPI.Repository;

namespace StudentAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //database
            builder.Services.AddDbContext<StudentDBContext>(options => options.
            UseSqlServer(builder.Configuration.GetConnectionString("StudentConnectionString")));

            builder.Services.AddScoped<IStudentRepository, StudentRepository>();

            //newly added for port changing(angular)
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost4200",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            //Enable CORS
            app.UseCors("AllowLocalhost4200");

            app.MapControllers();

            app.Run();
        }
    }
}