using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STD.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StdDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StdDbContext>>()))
            {
                // Look for any movies.
                if (context.Stds.Any())
                {
                    return;   // DB has been seeded
                }

                context.Stds.AddRange(
                    new Std
                    {
                        FirstName = "Bob",
                        LastName = "The builder",
                        Studies="Anime"
                    },

                    new Std
                    {
                        FirstName = "Bob1",
                        LastName = "The builder1",
                        Studies = "Anime"
                    },

                     new Std
                     {
                         FirstName = "Bob2",
                         LastName = "The builder2",
                         Studies = "Anime"
                     },

                     new Std
                     {
                         FirstName = "Bob3",
                         LastName = "The builder3",
                         Studies = "Jojo"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
