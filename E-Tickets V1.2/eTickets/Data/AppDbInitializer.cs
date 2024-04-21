using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Sinema 1",
                            Logo = "https://images2.imgbox.com/50/73/Nfq9bsaW_o.jpeg",
                            Description = "Açıklama 1"
                        },
                        new Cinema()
                        {
                            Name = "Sinema 2",
                            Logo = "https://images2.imgbox.com/cb/90/CK0Nf3rS_o.jpeg",
                            Description = "Açıklama 2"
                        },
                        new Cinema()
                        {
                            Name = "Sinema 3",
                            Logo = "https://images2.imgbox.com/7b/16/GZZNBbz6_o.jpeg",
                            Description = "Açıklama 3"
                        },
                        new Cinema()
                        {
                            Name = "Sinema 4",
                            Logo = "https://images2.imgbox.com/96/0a/y7eoyyD8_o.jpeg",
                            Description = "Açıklama 4"
                        },
                        new Cinema()
                        {
                            Name = "Sinema 5",
                            Logo = "https://images2.imgbox.com/1d/52/P9RuUpxF_o.jpeg",
                            Description = "Açıklama 5"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Oyuncu 1",
                            Bio = "Oyuncu biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/61/a9/FtCsRGNE_o.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Oyuncu 2",
                            Bio = "Oyuncu biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/18/f6/lbsHkQ8s_o.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Oyuncu 3",
                            Bio = "Oyuncu biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/10/1f/tArDKw45_o.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Oyuncu 4",
                            Bio = "Oyuncu biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/e3/20/Zeh51ZX9_o.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Oyuncu 5",
                            Bio = "Oyuncu biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/b0/40/a0RRBuKk_o.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Yapımcı 1",
                            Bio = "Yapımcı biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/98/2c/AmUB6tjZ_o.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Yapımcı 2",
                            Bio = "Yapımcı biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/2c/6c/Oeb4zEVD_o.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Yapımcı 3",
                            Bio = "Yapımcı biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/33/2a/ji9PodCW_o.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Yapımcı 4",
                            Bio = "Yapımcı biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/20/81/mqSGhdcp_o.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Yapımcı 5",
                            Bio = "Yapımcı biyografisi",
                            ProfilePictureURL = "https://images2.imgbox.com/16/5b/WJ4vP6Gy_o.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "Film özeti",
                            Price = 39.50,
                            ImageURL = "https://images2.imgbox.com/e2/08/AqsXJCDl_o.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Belgesel
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "Film özeti",
                            Price = 29.50,
                            ImageURL = "https://images2.imgbox.com/2f/91/PJMc7ttg_o.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Aksiyon
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "Film özeti",
                            Price = 39.50,
                            ImageURL = "https://images2.imgbox.com/f7/c8/v9wFMTaZ_o.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Korku
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "Film özeti",
                            Price = 39.50,
                            ImageURL = "https://images2.imgbox.com/58/4d/5lahfOAk_o.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Belgesel
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "Film özeti",
                            Price = 39.50,
                            ImageURL = "https://images2.imgbox.com/e7/0e/M4QtuMWw_o.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Animasyon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "Film özeti",
                            Price = 39.50,
                            ImageURL = "https://images2.imgbox.com/46/0c/q7jauK1Z_o.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Dram
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Admin1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "User1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
