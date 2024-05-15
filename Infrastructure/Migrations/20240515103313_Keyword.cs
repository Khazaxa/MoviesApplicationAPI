using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Keyword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    country_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    country_iso_code = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.country_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    department_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.department_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    gender_id = table.Column<int>(type: "int(11)", nullable: false),
                    gender = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.gender_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "genre",
                columns: table => new
                {
                    genre_id = table.Column<int>(type: "int(11)", nullable: false),
                    genre_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.genre_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "keyword",
                columns: table => new
                {
                    keyword_id = table.Column<int>(type: "int(11)", nullable: false),
                    keyword_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.keyword_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    language_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    language_code = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    language_name = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.language_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "language_role",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int(11)", nullable: false),
                    language_role = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.role_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    budget = table.Column<int>(type: "int(11)", nullable: true),
                    homepage = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    overview = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    popularity = table.Column<decimal>(type: "decimal(12,6)", precision: 12, scale: 6, nullable: true),
                    release_date = table.Column<DateOnly>(type: "date", nullable: true),
                    revenue = table.Column<long>(type: "bigint(20)", nullable: true),
                    runtime = table.Column<int>(type: "int(11)", nullable: true),
                    movie_status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tagline = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vote_average = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: true),
                    vote_count = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.movie_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    person_id = table.Column<int>(type: "int(11)", nullable: false),
                    person_name = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.person_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "production_company",
                columns: table => new
                {
                    company_id = table.Column<int>(type: "int(11)", nullable: false),
                    company_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.company_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "movie_genres",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: true),
                    genre_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_mg_genre",
                        column: x => x.genre_id,
                        principalTable: "genre",
                        principalColumn: "genre_id");
                    table.ForeignKey(
                        name: "fk_mg_movie",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "movie_keywords",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: false),
                    keyword_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_mk_keyword",
                        column: x => x.keyword_id,
                        principalTable: "keyword",
                        principalColumn: "keyword_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_mk_movie",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "movie_languages",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: true),
                    language_id = table.Column<int>(type: "int(11)", nullable: true),
                    language_role_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_ml_lang",
                        column: x => x.language_id,
                        principalTable: "language",
                        principalColumn: "language_id");
                    table.ForeignKey(
                        name: "fk_ml_movie",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id");
                    table.ForeignKey(
                        name: "fk_ml_role",
                        column: x => x.language_role_id,
                        principalTable: "language_role",
                        principalColumn: "role_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "production_country",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: true),
                    country_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_pc_country",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "country_id");
                    table.ForeignKey(
                        name: "fk_pc_movie",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "movie_cast",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: true),
                    person_id = table.Column<int>(type: "int(11)", nullable: true),
                    character_name = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender_id = table.Column<int>(type: "int(11)", nullable: true),
                    cast_order = table.Column<int>(type: "int(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_mca_gender",
                        column: x => x.gender_id,
                        principalTable: "gender",
                        principalColumn: "gender_id");
                    table.ForeignKey(
                        name: "fk_mca_movie",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id");
                    table.ForeignKey(
                        name: "fk_mca_per",
                        column: x => x.person_id,
                        principalTable: "person",
                        principalColumn: "person_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "movie_crew",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: true),
                    person_id = table.Column<int>(type: "int(11)", nullable: true),
                    department_id = table.Column<int>(type: "int(11)", nullable: true),
                    job = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_mcr_dept",
                        column: x => x.department_id,
                        principalTable: "department",
                        principalColumn: "department_id");
                    table.ForeignKey(
                        name: "fk_mcr_movie",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id");
                    table.ForeignKey(
                        name: "fk_mcr_per",
                        column: x => x.person_id,
                        principalTable: "person",
                        principalColumn: "person_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "movie_company",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int(11)", nullable: true),
                    company_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_mc_comp",
                        column: x => x.company_id,
                        principalTable: "production_company",
                        principalColumn: "company_id");
                    table.ForeignKey(
                        name: "fk_mc_movie",
                        column: x => x.movie_id,
                        principalTable: "movie",
                        principalColumn: "movie_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateIndex(
                name: "fk_mca_gender",
                table: "movie_cast",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "fk_mca_movie",
                table: "movie_cast",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "fk_mca_per",
                table: "movie_cast",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "fk_mc_comp",
                table: "movie_company",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "fk_mc_movie",
                table: "movie_company",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "fk_mcr_dept",
                table: "movie_crew",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "fk_mcr_movie",
                table: "movie_crew",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "fk_mcr_per",
                table: "movie_crew",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "fk_mg_genre",
                table: "movie_genres",
                column: "genre_id");

            migrationBuilder.CreateIndex(
                name: "fk_mg_movie",
                table: "movie_genres",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "fk_mk_keyword",
                table: "movie_keywords",
                column: "keyword_id");

            migrationBuilder.CreateIndex(
                name: "fk_mk_movie",
                table: "movie_keywords",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "fk_ml_lang",
                table: "movie_languages",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "fk_ml_movie",
                table: "movie_languages",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "fk_ml_role",
                table: "movie_languages",
                column: "language_role_id");

            migrationBuilder.CreateIndex(
                name: "fk_pc_country",
                table: "production_country",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "fk_pc_movie",
                table: "production_country",
                column: "movie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movie_cast");

            migrationBuilder.DropTable(
                name: "movie_company");

            migrationBuilder.DropTable(
                name: "movie_crew");

            migrationBuilder.DropTable(
                name: "movie_genres");

            migrationBuilder.DropTable(
                name: "movie_keywords");

            migrationBuilder.DropTable(
                name: "movie_languages");

            migrationBuilder.DropTable(
                name: "production_country");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "production_company");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "genre");

            migrationBuilder.DropTable(
                name: "keyword");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "language_role");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "movie");
        }
    }
}
