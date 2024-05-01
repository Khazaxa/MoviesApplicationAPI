using Core;
// using Core.Repositories;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddDbContext<IMoviesDbContext, MoviesDbContext>(options =>
            options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8, 0, 21))));
        builder.Services.AddAuthorization();

        // builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();
        // builder.Services.AddScoped<ICountriesRepository, CountriesRepository>();
        // builder.Services.AddScoped<ILanguagesRepository, LanguagesRepository>();
        // builder.Services.AddScoped<ILanguageRolesRepository, LanguageRolesRepository>();
        // builder.Services.AddScoped<IGenresRepository, GenresRepository>();
        // builder.Services.AddScoped<IKeywordsRepository, KeywordsRepository>();
        // builder.Services.AddScoped<IProductionCompaniesRepository, ProductionCompaniesRepository>();
        // builder.Services.AddScoped<IGendersRepository, GendersRepository>();
        // builder.Services.AddScoped<IPersonsRepository, PersonsRepository>();
        // builder.Services.AddScoped<IDepartmentsRepository, DepartmentsRepository>();
        
        builder.Services.AddControllers();
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}