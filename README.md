# MoviesApiWSEI

## Getting Started

`dotnet ef dbcontext scaffold "server=localhost;port=3306;database=movies;user=root;password=" Pomelo.EntityFrameworkCore.MySql -o Models`
`dotnet ef migrations add [NAZWA_MIGRACJI]`
`dotnet ef database update`



`{
"movieEntity": "string",
"title": "string",
"budget": 2147483647,
"homepage": "string",
"overview": "string",
"popularity": 0,
"releaseDate": "2024-05-14",
"revenue": 0,
"runtime": 2147483647,
"movieStatus": "Released",
"tagline": "string",
"voteAverage": 0,
"voteCount": 2147483647
}`