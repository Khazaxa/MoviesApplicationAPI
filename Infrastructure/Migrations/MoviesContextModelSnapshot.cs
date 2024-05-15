﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("country_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryIsoCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("country_iso_code");

                    b.Property<string>("CountryName")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("country_name");

                    b.HasKey("CountryId")
                        .HasName("PRIMARY");

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("Core.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("department_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("department_name");

                    b.HasKey("DepartmentId")
                        .HasName("PRIMARY");

                    b.ToTable("department", (string)null);
                });

            modelBuilder.Entity("Core.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .HasColumnType("int(11)")
                        .HasColumnName("gender_id");

                    b.Property<string>("Gender1")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("gender");

                    b.HasKey("GenderId")
                        .HasName("PRIMARY");

                    b.ToTable("gender", (string)null);
                });

            modelBuilder.Entity("Core.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int(11)")
                        .HasColumnName("genre_id");

                    b.Property<string>("GenreName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("genre_name");

                    b.HasKey("GenreId")
                        .HasName("PRIMARY");

                    b.ToTable("genre", (string)null);
                });

            modelBuilder.Entity("Core.Models.Keyword", b =>
                {
                    b.Property<int>("KeywordId")
                        .HasColumnType("int(11)")
                        .HasColumnName("keyword_id");

                    b.Property<string>("KeywordName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("keyword_name");

                    b.HasKey("KeywordId")
                        .HasName("PRIMARY");

                    b.ToTable("keyword", (string)null);
                });

            modelBuilder.Entity("Core.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("language_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<string>("LanguageCode")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("language_code");

                    b.Property<string>("LanguageName")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("language_name");

                    b.HasKey("LanguageId")
                        .HasName("PRIMARY");

                    b.ToTable("language", (string)null);
                });

            modelBuilder.Entity("Core.Models.LanguageRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int(11)")
                        .HasColumnName("role_id");

                    b.Property<string>("LanguageRole1")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("language_role");

                    b.HasKey("RoleId")
                        .HasName("PRIMARY");

                    b.ToTable("language_role", (string)null);
                });

            modelBuilder.Entity("Core.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<int?>("Budget")
                        .HasColumnType("int(11)")
                        .HasColumnName("budget");

                    b.Property<string>("Homepage")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("homepage");

                    b.Property<string>("MovieStatus")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("movie_status");

                    b.Property<string>("Overview")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("overview");

                    b.Property<decimal?>("Popularity")
                        .HasPrecision(12, 6)
                        .HasColumnType("decimal(12,6)")
                        .HasColumnName("popularity");

                    b.Property<DateOnly?>("ReleaseDate")
                        .HasColumnType("date")
                        .HasColumnName("release_date");

                    b.Property<long?>("Revenue")
                        .HasColumnType("bigint(20)")
                        .HasColumnName("revenue");

                    b.Property<int?>("Runtime")
                        .HasColumnType("int(11)")
                        .HasColumnName("runtime");

                    b.Property<string>("Tagline")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("tagline");

                    b.Property<string>("Title")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("title");

                    b.Property<decimal?>("VoteAverage")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)")
                        .HasColumnName("vote_average");

                    b.Property<int?>("VoteCount")
                        .HasColumnType("int(11)")
                        .HasColumnName("vote_count");

                    b.HasKey("MovieId")
                        .HasName("PRIMARY");

                    b.ToTable("movie", (string)null);
                });

            modelBuilder.Entity("Core.Models.MovieCast", b =>
                {
                    b.Property<int?>("CastOrder")
                        .HasColumnType("int(5)")
                        .HasColumnName("cast_order");

                    b.Property<string>("CharacterName")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)")
                        .HasColumnName("character_name");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int(11)")
                        .HasColumnName("gender_id");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int(11)")
                        .HasColumnName("person_id");

                    b.HasIndex(new[] { "GenderId" }, "fk_mca_gender");

                    b.HasIndex(new[] { "MovieId" }, "fk_mca_movie");

                    b.HasIndex(new[] { "PersonId" }, "fk_mca_per");

                    b.ToTable("movie_cast", (string)null);
                });

            modelBuilder.Entity("Core.Models.MovieCompany", b =>
                {
                    b.Property<int?>("CompanyId")
                        .HasColumnType("int(11)")
                        .HasColumnName("company_id");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id");

                    b.HasIndex(new[] { "CompanyId" }, "fk_mc_comp");

                    b.HasIndex(new[] { "MovieId" }, "fk_mc_movie");

                    b.ToTable("movie_company", (string)null);
                });

            modelBuilder.Entity("Core.Models.MovieCrew", b =>
                {
                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int(11)")
                        .HasColumnName("department_id");

                    b.Property<string>("Job")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("job");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int(11)")
                        .HasColumnName("person_id");

                    b.HasIndex(new[] { "DepartmentId" }, "fk_mcr_dept");

                    b.HasIndex(new[] { "MovieId" }, "fk_mcr_movie");

                    b.HasIndex(new[] { "PersonId" }, "fk_mcr_per");

                    b.ToTable("movie_crew", (string)null);
                });

            modelBuilder.Entity("Core.Models.MovieGenre", b =>
                {
                    b.Property<int?>("GenreId")
                        .HasColumnType("int(11)")
                        .HasColumnName("genre_id");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id");

                    b.HasIndex(new[] { "GenreId" }, "fk_mg_genre");

                    b.HasIndex(new[] { "MovieId" }, "fk_mg_movie");

                    b.ToTable("movie_genres", (string)null);
                });

            modelBuilder.Entity("Core.Models.MovieKeyword", b =>
                {
                    b.Property<int?>("KeywordId")
                        .IsRequired()
                        .HasColumnType("int(11)")
                        .HasColumnName("keyword_id")
                        .HasColumnOrder(1);

                    b.Property<int?>("MovieId")
                        .IsRequired()
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id")
                        .HasColumnOrder(0);

                    b.HasIndex(new[] { "KeywordId" }, "fk_mk_keyword");

                    b.HasIndex(new[] { "MovieId" }, "fk_mk_movie");

                    b.ToTable("movie_keywords", (string)null);
                });

            modelBuilder.Entity("Core.Models.MovieLanguage", b =>
                {
                    b.Property<int?>("LanguageId")
                        .HasColumnType("int(11)")
                        .HasColumnName("language_id");

                    b.Property<int?>("LanguageRoleId")
                        .HasColumnType("int(11)")
                        .HasColumnName("language_role_id");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id");

                    b.HasIndex(new[] { "LanguageId" }, "fk_ml_lang");

                    b.HasIndex(new[] { "MovieId" }, "fk_ml_movie");

                    b.HasIndex(new[] { "LanguageRoleId" }, "fk_ml_role");

                    b.ToTable("movie_languages", (string)null);
                });

            modelBuilder.Entity("Core.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int(11)")
                        .HasColumnName("person_id");

                    b.Property<string>("PersonName")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("person_name");

                    b.HasKey("PersonId")
                        .HasName("PRIMARY");

                    b.ToTable("person", (string)null);
                });

            modelBuilder.Entity("Core.Models.ProductionCompany", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int(11)")
                        .HasColumnName("company_id");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("company_name");

                    b.HasKey("CompanyId")
                        .HasName("PRIMARY");

                    b.ToTable("production_company", (string)null);
                });

            modelBuilder.Entity("Core.Models.ProductionCountry", b =>
                {
                    b.Property<int?>("CountryId")
                        .HasColumnType("int(11)")
                        .HasColumnName("country_id");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int(11)")
                        .HasColumnName("movie_id");

                    b.HasIndex(new[] { "CountryId" }, "fk_pc_country");

                    b.HasIndex(new[] { "MovieId" }, "fk_pc_movie");

                    b.ToTable("production_country", (string)null);
                });

            modelBuilder.Entity("Core.Models.MovieCast", b =>
                {
                    b.HasOne("Core.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .HasConstraintName("fk_mca_gender");

                    b.HasOne("Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("fk_mca_movie");

                    b.HasOne("Core.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .HasConstraintName("fk_mca_per");

                    b.Navigation("Gender");

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Core.Models.MovieCompany", b =>
                {
                    b.HasOne("Core.Models.ProductionCompany", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("fk_mc_comp");

                    b.HasOne("Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("fk_mc_movie");

                    b.Navigation("Company");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Core.Models.MovieCrew", b =>
                {
                    b.HasOne("Core.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("fk_mcr_dept");

                    b.HasOne("Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("fk_mcr_movie");

                    b.HasOne("Core.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .HasConstraintName("fk_mcr_per");

                    b.Navigation("Department");

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Core.Models.MovieGenre", b =>
                {
                    b.HasOne("Core.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .HasConstraintName("fk_mg_genre");

                    b.HasOne("Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("fk_mg_movie");

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Core.Models.MovieKeyword", b =>
                {
                    b.HasOne("Core.Models.Keyword", "Keyword")
                        .WithMany()
                        .HasForeignKey("KeywordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_mk_keyword");

                    b.HasOne("Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_mk_movie");

                    b.Navigation("Keyword");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Core.Models.MovieLanguage", b =>
                {
                    b.HasOne("Core.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("fk_ml_lang");

                    b.HasOne("Core.Models.LanguageRole", "LanguageRole")
                        .WithMany()
                        .HasForeignKey("LanguageRoleId")
                        .HasConstraintName("fk_ml_role");

                    b.HasOne("Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("fk_ml_movie");

                    b.Navigation("Language");

                    b.Navigation("LanguageRole");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Core.Models.ProductionCountry", b =>
                {
                    b.HasOne("Core.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .HasConstraintName("fk_pc_country");

                    b.HasOne("Core.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("fk_pc_movie");

                    b.Navigation("Country");

                    b.Navigation("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
