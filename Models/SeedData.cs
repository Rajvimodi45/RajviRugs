using System;
using System.Linq;
using RajviRugs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RajviRugs.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RajviRugsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RajviRugsContext>>()))
            {
                if (context.Rugs.Any())
                {
                    return;   // DB has been seeded
                }

                context.Rugs.AddRange(
                    new Rugs
                    {
                        Title = "Jane Seymour 5' x 8' Open Hearts Rug",
                        Color = "Pink",
                        Type = "Squre",
                        Price = 5.00M,
                        Rating = 3.50M
                    },
                    new Rugs {
                        Title = "5' x 8' Solid Shag Rug	",
                        Color = "Yellow",
                        Type = "Round",
                        Price = 6.00M,
                        Rating = 2.50M
                    },
                    new Rugs
                    {
                        Title = "Rug three",
                        Color = "Yellow",
                        Type = "Round",
                        Price = 2.5M,
                        Rating = 2.5M
                    },
                    new Rugs
                    {
                        Title = "2' x 5' Solid Shag Runner Rug",
                        Color = "Black",
                        Type = "Round",
                        Price = 4.00M,
                        Rating = 4.50M
                    },
                    new Rugs
                    {
                        Title = "Jane Seymour 2' x 6' Open Hearts Runner Rug",
                        Color = "Blue",
                        Type = "Black",
                        Price = 7.00M,
                        Rating = 5.00M
                    },
                    new Rugs
                    {
                        Title = "5' x 8' Moroccan Shag Rug",
                        Color = "Yellow",
                        Type = "Round",
                        Price = 6.00M,
                        Rating = 4.50M

                    },
                    new Rugs
                    {
                        Title = "ane Seymour 2' x 6' Open Hearts Runner Rug",
                        Color = "Pink",
                        Type = "Round",
                        Price = 5.00M,
                        Rating = 4.50M
                    },
                    new Rugs
                    {
                        Title = "6' x 9' Moroccan Shag Rug",
                        Color = "Yellow",
                        Type = "Squre",
                        Price = 4.00M,
                        Rating = 4.00M

                    },
                    new Rugs
                    {
                        Title = "5' 5 x 8' Santiago Rug",
                        Color = "Pink",
                        Type = "Squre",
                        Price = 4.00M,
                        Rating = 3.50M
                    },
                    new Rugs
                    {
                        Title = "Jane Seymour 8' x 10' Open Hearts Rug",
                        Color = "Yellow",
                        Type = "Round",
                        Price = 5.00M,
                        Rating = 4.50M
                    }
                    );

                }
           
            }
        }
         
    }

