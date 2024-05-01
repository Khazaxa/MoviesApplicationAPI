# MoviesApiWSEI

## Getting Started


1. **Start the Services**

   Use Docker Compose to start the services defined in your `docker-compose.yml` file.

   ```bash
   docker-compose up
   ```

   Add the `-d` flag to run the services in detached mode (in the background):

   ```bash
   docker-compose up -d
   ```

2. **Access the Application**

   Once the services are up and running, you can access the application via the URLs provided in the `docker-compose.yml` file or as documented in the project.

### Creating new db migration
* Ensure Entity Framework tools are installed `dotnet tool install --global dotnet-ef`
* In project Infrastructure catalog run command `dotnet ef migrations add [MIGRATION_NAME]`
* Then run command `dotnet ef database update`