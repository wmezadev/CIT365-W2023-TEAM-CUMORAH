using Microsoft.EntityFrameworkCore;
using MegaDeskASP.Data;

namespace MegaDeskASP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskASPContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskASPContext>>()))
            {
                if (context == null || context.Quote == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Quote
                    {
                        CustomerName = "Jose Javier",
                        Width = 10,
                        Height = 4,
                        SurfaceMaterial = "Laminate",
                        Drawer = 4,
                        ProductionTime = 7,
                        DateCreated = DateTime.Parse("1987-8-13"),
                        Price = 7.99M
                    },

                    new Quote
                    {
                        CustomerName = "William Meza",
                        Width = 8,
                        Height = 2,
                        SurfaceMaterial = "Oak",
                        Drawer = 5,
                        ProductionTime = 7,
                        DateCreated = DateTime.Parse("1990-3-13"),
                        Price = 8.99M
                    },

                    new Quote
                    {
                        CustomerName = "Arturo Ocampo",
                        Width = 10,
                        Height = 4,
                        SurfaceMaterial = "Rosewood",
                        Drawer = 4,
                        ProductionTime = 7,
                        DateCreated = DateTime.Parse("1984-3-13"),
                        Price = 3.99M
                    },

                    new Quote
                    {
                        CustomerName = "Anderson Gil",
                        Width = 8,
                        Height = 9,
                        SurfaceMaterial = "Pine",
                        Drawer = 6,
                        ProductionTime = 5,
                        DateCreated = DateTime.Parse("1994-10-20"),
                        Price = 4.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
