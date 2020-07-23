
using Customers.Infrastructure;
using Customers.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Customers.Api.Seed
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                ApplicationDbContext context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();


                if (!context.Customers.Any())
                {
                    var customers = new Customer[]
                    {
                         new Customer
                         {
                             FirstName = "Sunil",
                             LastName = "Gupta",
                             AddressLine1 = "Crossing Republic",
                             AddressLine2 = "Ghaziabad",
                             Mobile = "9540056062",
                             City = "Ghaziabad",
                             Pincode = "201016",
                             CreatedAt = DateTime.Now,
                             CreatedBy = 1,
                             IsActive = true                             
                         },
                         new Customer
                         {
                             FirstName = "Sunil1",
                             LastName = "Gupta1",
                             AddressLine1 = "Crossing Republic",
                             AddressLine2 = "Ghaziabad",
                             Mobile = "9540056062",
                             City = "Ghaziabad",
                             Pincode = "201016",
                             CreatedAt = DateTime.Now,
                             CreatedBy = 1,
                             IsActive = true
                         },
                         new Customer
                         {
                             FirstName = "Sunil2",
                             LastName = "Gupta2",
                             AddressLine1 = "Crossing Republic",
                             AddressLine2 = "Ghaziabad",
                             Mobile = "9540056062",
                             City = "Ghaziabad",
                             Pincode = "201016",
                             CreatedAt = DateTime.Now,
                             CreatedBy = 1,
                             IsActive = true
                         },

                    };


                    context.AddRange(customers);
                }

                context.SaveChanges();
            }
        }
    }
}
