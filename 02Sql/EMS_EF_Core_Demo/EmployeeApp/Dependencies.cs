using EmployeeDataAccess.Models;
using EmployeeLib.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EmployeeApp
{
   public static class Dependencies
    {

        public static IRepositoryEmployee<EmployeeLib.Employee> CreateEmployeeRepository()
        {
            var configurBuilder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("Secrets.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = configurBuilder.Build();
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("EmployeeDb"));
            var options = optionsBuilder.Options;
            EmployeeDbContext db = new EmployeeDbContext(options);
            return new EmployeeDataAccess.Repository.RepositoryEmployee(db);
        }
    }
}
