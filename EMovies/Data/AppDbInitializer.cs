using EMovies.Data.Enums;
using EMovies.Models;

namespace EMovies.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();

            //Cinemas
            if (!context.Cinemas.Any())
            {
                context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Geetha Arts",
                            Logo = "/images/Geetha_Arts.jpg",
                            Description = "This is the Description of First Cinemas"
                        },
                        new Cinema()
                        {
                            Name = "PVP Movies",
                            Logo = "/images/pvp.png",
                            Description = "This is the Description of Second Cinemas"
                        },
                        new Cinema()
                        {
                            Name = "UV Creations",
                            Logo = "/images/UV_Creations.jpg",
                            Description = "This is the Description of Third Cinemas"
                        },
                        new Cinema()
                        {
                            Name = "Varahi Movies",
                            Logo = "/images/Varahi_Movies.jpg",
                            Description = "This is the Description of fourth Cinemas"
                        },
                        new Cinema()
                        {
                            Name = "GMB Entertainments",
                            Logo = "/images/GMB.jpg",
                            Description = "This is the Description of Fifth Cinemas"
                        },
                        new Cinema()
                        {
                            Name = "Mithry Movies",
                            Logo = "/images/Mythri_Movies.jpg",
                            Description = "This is the Description of Sixth Cinemas"
                        }
                    });
                context.SaveChanges();
            }

            // Actors
            if (!context.Actors.Any())
            {
                context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePictureURL = "/images/Actor-1.jpg",
                            FullName = "Johny Depp",
                            Bio = "This is the Description of First Actor"
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "/images/Mahesh_Babu.jpg",
                            FullName = "Mahesh Babu",
                            Bio = "This is the Description of Second Actor"
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "/images/Angelina_Jolie.jpg",
                            FullName = "Angelina Jolie",
                            Bio = "This is the Description of Third Actor"
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "/images/Kate_Winslet.jpg",
                            FullName = "Kate Winslet",
                            Bio = "This is the Description of Fourth Actor"
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "/images/dwayne-johnson.jpg",
                            FullName = "Dwayne Johnson",
                            Bio = "This is the Description of Fifth Actor"
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "/images/chris-hemsworth.jpg",
                            FullName = "Chris Hemsworth",
                            Bio = "This is the Description of Fifth Actor"
                        }
                    });
                context.SaveChanges();

            }

            // Producers
            if (!context.Producers.Any())
            {
                context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProfilePictureURL = "/images/Angelina_Jolie.jpg",
                            FullName = "Producer 1",
                            Bio = "This is the Description of First Producer"
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "/images/Angelina_Jolie.jpg",
                            FullName = "Producer 2",
                            Bio = "This is the Description of Second Producer"
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "/images/Angelina_Jolie.jpg",
                            FullName = "Producer 3",
                            Bio = "This is the Description of Third Producer"
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "/images/Angelina_Jolie.jpg",
                            FullName = "Producer 4",
                            Bio = "This is the Description of Fourth Producer"
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "/images/Angelina_Jolie.jpg",
                            FullName = "Producer 5",
                            Bio = "This is the Description of Fifth Producer"
                        }
                    });
                context.SaveChanges();

            }
            // Movies
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Scooby-Do",
                            Description = "This is a Scooby-Do Movie Description",
                            Price = 38.96,
                            ImageURL = "/images/pof-1.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Pirates Of Caribbean",
                            Description = "Pirates of the Caribbean is a series of fantasy swashbuckler films produced by Jerry Bruckheimer and based on Walt Disney's theme park attraction of the same name. The film series serves as a major component of the eponymous media franchise.",
                            Price = 99.96,
                            ImageURL = "/images/pof-1.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaID = 2,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Fantasy
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is a Race Movie Description",
                            Price = 50.96,
                            ImageURL = "/images/pof-1.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaID = 3,
                            ProducerID = 2,
                            MovieCategory = MovieCategory.Documentry
                        },
                        new Movie()
                        {
                            Name = "Gost",
                            Description = "This is a Cold Soles Movie Description",
                            Price = 50.96,
                            ImageURL = "/images/pof-1.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is 'The Shawshank Redemption' Movie Description",
                            Price = 50.96,
                            ImageURL = "/images/pof-1.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaID = 5,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                context.SaveChanges();
            }
        }
    }
}
