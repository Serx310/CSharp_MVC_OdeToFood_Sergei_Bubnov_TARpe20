using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class AppDataInit
    {
        public static void SeedRestaurant(ApplicationDbContext context)
        {
            if (!context.Restaurants.Any())
            {
                context.Restaurants.Add(new Restaurant
                {
                    Name = "Hesburger",
                    City = "Turku",
                    Country = "Finland",
                    Reviews = new List<RestaurantReview>() { new RestaurantReview() {
                        Rating = 10,
                        Body = "Lit"
                    } }
                });

                context.Restaurants.Add(new Restaurant
                            {
                                Name = "Suliko",
                                City = "Tallinn",
                                Country = "Estonia",
                });
                context.SaveChanges();
        }
        }
    }
}
