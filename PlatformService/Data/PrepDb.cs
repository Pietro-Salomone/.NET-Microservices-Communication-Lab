using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder appBuilder, bool isProd)
        {
        
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProd);
            }
        }
        
        private static void SeedData(AppDbContext context,bool isProd)
        {
            if(isProd)
            {
                try
                {
                    Console.WriteLine("Attempting to apply migrations...");
                    context.Database.Migrate();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Could not run migrations: {ex.Message}");
                }
                
            }
            if(!context.Platforms.Any())
            {
                Console.WriteLine("Seeding data...");
                
                context.Platforms.AddRange(
                    new Platform(){Name = "Dot Net", Publisher = "Microsoft", Cost = "Free"},
                    new Platform(){Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free"},
                    new Platform(){Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free"}
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We already have data!");
            }
        }
    }
}