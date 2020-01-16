# Entity Framework Core Steps:

## Package Manager Console (for VS2019 users)
- Run following commands in your Data Layer project in the VS2019 PMC (in your Tools menu option->Nuget Package Manager -> Package Manager Console)
- `Install-Package Microsoft.EntityFrameworkCore.SqlServer`
- `Install-Package Microsoft.EntityFrameworkCore.Tools`
- `Install-Package Microsoft.EntityFrameworkCore.Design`
- Build the project before Scaffolding
- `Get-Help about_EntityFrameworkCore` - See the EF help commands
- `Scaffold-DbContext -connection "Server=<DB Server Name>;Database=<DB Name>;user id=<username>;Password=<password>;" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir <Output Directory name> -context <context name>` - Its is mandatory to provide connectio string and the provider rest parameters are optional

## .NET core CLI COMMANDS (specially VSCODE users)
- Run following commands in your Data Layer project in the vscode terminal/gitbash/Command prompt)
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
- `dotnet add package Microsoft.EntityFrameworkCore.Design`
- `dotnet add package Microsoft.EntityFrameworkCore.Tool`
- `dotnet ef` - to check EF is installed
- `dotnet ef -h` -See the EF help commands
- `dotnet ef dbcontext scaffold -h` - see if help about EF Db Context Scaffold commands
- `dotnet ef dbcontext scaffold -connection "Server=<server name>;Database=<Db Name>;user id=<username>;Password=<password>;" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir <Output Directory name> -context <context name>` - to get all Entities mapped from database objects to C# classes.


[Reference](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)


## To move the connection string from generated dbcontext file to JSON configuration file:
1. add package `Microsoft.Extensions.Configuration.Json` to the console app. (turns out the other two packages from before are dependencies that are automatically added)
2. add new item to console app project, type "JSON File", named "appsettings.json", with these contents:

```
{
  "ConnectionStrings": {
    "<name you give to this data source>": "<your connection string>"
  }
}
```
3. right-click on "appsettings.json" in the solution explorer, go to Properties, change "Copy to Output Directory" to "Copy if newer".
4. make a ".gitignore" file in your solution directory, with the contents "appsettings.json".
5. in `Program.Main` of your console app, add the code:

```
var configBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
IConfigurationRoot configuration = configBuilder.Build();
```
6. to get the options ready to make a dbcontext, use the code (substituting the right stuff):
```
var optionsBuilder = new DbContextOptionsBuilder<YourAppDbContext>();
optionsBuilder.UseSqlServer(configuration.GetConnectionString("<name you gave to the data source>"));
var options = optionsBuilder.Options;
```
7. then, when you need to make a dbcontext (to give you to your repository classes): `new YourAppDbContext(options)`.
