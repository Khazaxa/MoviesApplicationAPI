using Core;
// using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class MoviesDbContext : DbContext, IMoviesDbContext
{
    public MoviesDbContext() : base() { }

    public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options) { }

    // public DbSet<Movie> Movies { get; set; }
    // public DbSet<Country> Countries { get; set; }
    // public DbSet<Language> Languages { get; set; }
    // public DbSet<LanguageRole> LanguageRoles { get; set; }
    // public DbSet<Genre> Genres { get; set; }
    // public DbSet<Keyword> Keywords { get; set; }
    // public DbSet<ProductionCompany> ProductionCompanies { get; set; }
    // public DbSet<Gender> Genders { get; set; }
    // public DbSet<Person> Persons { get; set; }
    // public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database==movies;user=root;password=",
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}