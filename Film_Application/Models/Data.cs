using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Application.Models
{
    public class Data:DbContext
    {
        public DbSet<Movie> FileData { get; set; }    
        public DbSet<Category> CategoryData{ get; set; }
        public DbSet<User> Users { get;set; }
        public DbSet<Order> Orders { get;set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Dom;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id=1,
                Name = "Life",
                Description = "This is the Life movie description",
                Price = 390,
                Count = 23,
                Image = "https://pbs.twimg.com/media/DBlhtBmXoAAj-j2?format=jpg&name=large",
                FileCraetedData=new DateTime(2002,03,2),
                NameComapany = "ComanyName1",
            });;
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id=2,
                Name = "The Shawshank Redemption",
                Description = "This is the Shawshank Redemption description",
                Price = 45,
                Count = 13,
                Image = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg",
                FileCraetedData = new DateTime(2005, 08, 1),
                NameComapany="ComanyName2",
            });;
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id=3,
                Name = "Ghost",
                Description = "This is the Ghost movie description",
                Price = 454,
                Count=23,
                Image = "https://m.media-amazon.com/images/I/71-HovwGgJL._AC_UF1000,1000_QL80_.jpg",
                FileCraetedData = new DateTime(2009, 12, 3),
                NameComapany = "ComanyName3",
            });;
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id=4,
                Name = "Race",
                Description = "This is the Race movie description",
                Price = 32,
                Count=13,
                Image = "https://m.media-amazon.com/images/M/MV5BMTQ3MDM1MDU2NF5BMl5BanBnXkFtZTgwMzM3OTIzNzE@._V1_.jpg",
                FileCraetedData = new DateTime(2011, 12, 3),
                NameComapany = "ComanyName4",

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id=5,
                Name = "Scoob",
                Description = "This is the Scoob movie description",
                Price = 390,
                Count= 13,
                Image= "https://parentpreviews.com/images/made/legacy-pics/scoob-5_668_330_80_int_s_c1.jpg",
                FileCraetedData = new DateTime(2011, 12, 3),
                NameComapany = "ComanyName5",

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 6,
                Name = "Cold Soles",
                Description = "This is the Cold Soles movie description",
                Price = 390,
                Count=22,
                Image = "https://m.media-amazon.com/images/M/MV5BOWI2MTFmMjAtNjM1ZC00ZGNhLWJjNWQtOWMwZDI3MzYxOTQwXkEyXkFqcGdeQXVyMjIxNTg0MDQ@._V1_.jpg",
                FileCraetedData = new DateTime(2011, 12, 3),
                NameComapany = "NameCompany6"
            }); modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                
                Janre =   "Drama" ,
            }); modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                
                Janre = "Cartoon",
            }); modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                
                Janre = "Documentary",
            }); modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                
                Janre = "Horror",
            }); modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 5,
                
                Janre = "Action",
            }); modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 6,
                Janre = "Documentary",
            });
       }
    }
}
