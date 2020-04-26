using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2UrDoorBakery.Models
{
    public class BakeryDbContext : IdentityDbContext<IdentityUser>
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options)
    : base(options)
        {

        }

        public DbSet<Bakery> Bakery { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 1,
                Name = "3D Bear Cake with Letter",
                Price = 28.50M,
                Description = "3D Bear Cake made with Gelatine and Cream Cheese, along with candy and marshmallow!",
                ImageThumbnailUrl = "https://zhwebproject.blob.core.windows.net/files/3DBearCake1.JPG",
            });

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 2,
                Name = "3D Bear Cake with Pink Bow Tie",
                Price = 25.50M,
                Description = "3D Bear Cake made with Gelatine and Cream Cheese!",
                ImageThumbnailUrl =
                    "https://zhwebproject.blob.core.windows.net/files/3DBearCake2.jpg",
            });

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 3,
                Name = "Banana Nut Bread",
                Price = 4.50M,
                Description = "Fresh Banana with delicious walnut!",
                ImageThumbnailUrl = "https://zhwebproject.blob.core.windows.net/files/BananaNutBread.JPG",
            });

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 4,
                Name = "Bunny Hot Dogs",
                Price = 9.50M,
                Description = "This price comes with 4 cute bunny hot dogs.",
                ImageThumbnailUrl = "https://zhwebproject.blob.core.windows.net/files/BunnyHotDog.JPG",
            });

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 5,
                Name = "Chocolate Cream Roll",
                Price = 8.95M,
                Description = "Chocolate cake with chocolate cream!",
                ImageThumbnailUrl =
                    "https://zhwebproject.blob.core.windows.net/files/ChocolateCreamRoll.JPG",
            });

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 6,
                Name = "Butter Croissant",
                Price = 1.95M,
                Description = "Fresh Home-made Butter Croissant.",
                ImageThumbnailUrl = "https://zhwebproject.blob.core.windows.net/files/Croissant1.JPG",
            });

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 7,
                Name = "Pork Floss Roll",
                Price = 9.95M,
                Description = "A Must Try Roll if you haven't tried yet",
                ImageThumbnailUrl = "https://zhwebproject.blob.core.windows.net/files/PorkFlossRoll.JPG",
            });

            modelBuilder.Entity<Bakery>().HasData(new Bakery
            {
                BakeryId = 8,
                Name = "Strawberry Cream Cake",
                Price = 15.95M,
                Description = "Nothing is better than a cream cake with Strawberries!",
                ImageThumbnailUrl = "https://zhwebproject.blob.core.windows.net/files/StrawberryCake1.jpg",
            });
        }
    }
}
