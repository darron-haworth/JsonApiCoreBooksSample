using System;
using System.Collections.Generic;
using System.Linq;
using JsonApiCoreBooksSample.Domain;
using JsonApiCoreBooksSample.Repository;
using JsonApiDotNetCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JsonApiCoreBooksSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            { // use whatever provider you want, this is just an example
                options.UseSqlite("Data Source=JsonApiCoreSampleData.db");
            }, ServiceLifetime.Transient);

            // add jsonapi dotnet core
            services.AddJsonApi<AppDbContext>(
                options =>
                {
                    options.RelativeLinks = false;
                    options.AllowClientGeneratedIds = true;
                    options.IncludeTotalRecordCount = true;
                }

                );
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, AppDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Books.Any() == false)
            {

                context.Books.AddRange(
                     new Book
                     {
                         Title = "The Gulag Archipelago",
                         Isbn = "978-1843430858",
                         PublishDate = DateTime.Parse("2003-1-03"),
                         BookReviews = new List<Review> { new Review { ReviewerName = "Sanjay", ReviewBody = "Tough read!" } }
                     },

                     new Book
                     {
                         Title = "12 Rules for Life: An Antidote to Chaos",
                         Isbn = "978-0345816023",
                         PublishDate = DateTime.Parse("2018-1-23"),
                         BookReviews = new List<Review> { new Review { ReviewerName = "FSWarrior1", ReviewBody = "Can't wait for January 23d!" } }
                     },

                     new Book
                     {
                         Title = "Don't Hurt People and Don't Take Their Stuff: A Libertarian Manifesto",
                         Isbn = "978-0062308276",
                         PublishDate = DateTime.Parse("2015-03-31"),
                         BookReviews = new List<Review> {
                             new Review { ReviewerName = "TimPool", ReviewBody = "Loved!" },
                             new Review { ReviewerName = "HuffPost", ReviewBody = "Hated!" },
                             new Review { ReviewerName = "AverageJoe", ReviewBody = "Meh" }
                         }
                     },
                   new Book
                   {
                       Title = "Design Patterns: Elements of Reusable Object-Oriented Software",
                       Isbn = "978-0201633610",
                       PublishDate = DateTime.Parse("1994-11-10"),
                       BookReviews = new List<Review> { new Review { ReviewerName = "Padma", ReviewBody = "A must!" } }
                   }
                );
                context.SaveChanges();

                context.Authors.AddRange(
                    new Author
                    {
                        FirstName = "Aleksandr",
                        LastName = "Solzhenitsyn",
                        AuthorBooks = context.Books.Where(b => b.Isbn == "978-1843430858").ToList()
                    },
                    new Author
                    {
                        FirstName = "Jordan",
                        LastName = "Peterson",
                        AuthorBooks = context.Books.Where(b => b.Isbn == "978-0345816023").ToList()
                    },
                    new Author
                    {
                        FirstName = "Matt",
                        LastName = "Kibbe",
                        AuthorBooks = context.Books.Where(b => b.Isbn == "978-0062308276").ToList()
                    },
                    new Author
                    {
                        FirstName = "Erich",
                        LastName = "Gamma",
                        AuthorBooks = context.Books.Where(b => b.Isbn == "978-978-0201633610").ToList()
                    }

                );
                context.SaveChanges();

                context.Reviews.AddRange(

                );
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseJsonApi();
        }
    }
}
