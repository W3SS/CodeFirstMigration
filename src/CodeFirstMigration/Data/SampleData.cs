using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace CodeFirstMigration.Data
{
    public class SampleData
    {
        public async static Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService<ApplicationDbContext>();
            await db.Database.EnsureCreatedAsync();

            // Add Sample Data Insertions
        }
    }
}
