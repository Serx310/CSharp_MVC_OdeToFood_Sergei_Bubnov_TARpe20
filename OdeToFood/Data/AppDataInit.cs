using Microsoft.AspNetCore.Identity;
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
                for (int i = 0; i < 1000; i++)
                {
                    context.Restaurants.Add(new Restaurant
                    {
                        Name = $"Cinnamon Club {i}",
                        City = "Turku",
                        Country = "Finland",
                        Reviews = new List<RestaurantReview>() { new RestaurantReview() {
                        Rating = 10,
                        Body = "Lit"
                    } }
                    });
                }
                context.SaveChanges();
            }
        }
        public static void SeedIdentity(UserManager<UserProfile> userManager, RoleManager<AppRole> roleManager)
        {
            var role = new AppRole();
            role.Name = "Admin";
            if(!roleManager.RoleExistsAsync("Admin").Result)
            {
                var result = roleManager.CreateAsync(role).Result;
                if (!result.Succeeded)
                {
                    foreach(var identityError in result.Errors)
                    {
                        Console.WriteLine($"Can not create role! Error: {identityError.Description}");
                    }
                }
            }
        }
    }
}
