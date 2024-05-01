# MoviesApiWSEI

## Getting Started

`dotnet ef dbcontext scaffold "server=localhost;port=3306;database=movies;user=root;password=" Pomelo.EntityFrameworkCore.MySql -o Models`
`dotnet ef migrations add [NAZWA_MIGRACJI]`
`dotnet ef database update`
