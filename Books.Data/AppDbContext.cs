using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Details> Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            modelBuilder.Entity<Books>().ToTable("Book");
            modelBuilder.Entity<Details>().ToTable("Detail");
            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 1,
                Name = "Where the Crawdads Sing",
                Author = "Delia Owens",
                Price = 14.30,
                BestOfTheWeek = false,
                Trendy =true,
                New =false,
              Image = "https://images-na.ssl-images-amazon.com/images/I/51NYjNgldSL._SX330_BO1,204,203,200_.jpg"
            }

           );
            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 2,
                Name = "Becoming",
                Author = "Michelle Obama",
                Price = 11.89,
                BestOfTheWeek = false,
                Trendy = true,
                New = false,
                Image = "https://images-na.ssl-images-amazon.com/images/I/414JfiBCutL._SX327_BO1,204,203,200_.jpg"
            }

          );
            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 3,
                Name = "White Fragility: Why It's So Hard for White People to Talk About Racism",
                Author = "Robin DiAngelo",
                Price = 12.24,
                BestOfTheWeek =true,
                Trendy = true,
                New = true,
                Image = "https://images-na.ssl-images-amazon.com/images/I/51aDh-YMFAL._SX331_BO1,204,203,200_.jpg"
            }

        );
            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 4,
                Name = "Burn After Writing",
                Author = "Sharon Jones",
                Price = 8.40,
                BestOfTheWeek = true,
                Trendy = false,
                New = false,
                Image = "https://images-na.ssl-images-amazon.com/images/I/51OelfoY-ML._SX330_BO1,204,203,200_.jpg"
            }

      );
            modelBuilder.Entity<Books>().HasData(new Books
            {
                Id = 5,
                Name = "So You Want to Talk About Race",
                Author = "Ijeoma Oluo",
                Price = 27.00,
                BestOfTheWeek = true,
                Trendy = false,
                New = false,
                Image = "https://images-na.ssl-images-amazon.com/images/I/41XIlsrvpIL._SX331_BO1,204,203,200_.jpg"
            }

      );
            modelBuilder.Entity<Details>().HasData(new Details
            {
                Id = 1,
                Description = "For years, rumors of the Marsh Girl "+
                "have haunted Barkley Cove, a quiet town on the North Carolina coast. So in late 1969, when handsome Chase Andrews is found dead, the locals immediately suspect Kya Clark, the so-called Marsh Girl."+
                " But Kya is not what they say. Sensitive and intelligent, she has survived for years alone in the marsh that she calls home, finding friends in the gulls and lessons in the sand"+
                "Then the time comes when she yearns to be touched and loved. When two young men from town become intrigued by her wild beauty, Kya opens herself to a new life--until the unthinkable happens.",
                Editorial = "\"I can't even express how much I love this book! I didn't want this story to end!\"--Reese Witherspoon"+
"\"Painfully beautiful.\"--The New York Times Book Review",
                Ratings = 4.8,
                Review = null
               
            }

          );

            modelBuilder.Entity<Details>().HasData(new Details
            {
                Id = 2,
                Description = "In a life filled with meaning and accomplishment, Michelle Obama has emerged as one of the most iconic and compelling women of our era."+
                "As First Lady of the United States of America—the first African American to serve in that role—she helped create the most welcoming and inclusive White House in history, while also establishing herself as a powerful advocate for women and girls in the U.S. and around the world, dramatically changing the ways that families pursue healthier and more active lives, and standing with her husband as he led America through some of its most harrowing moments. Along the way, she showed us a few dance moves, crushed Carpool Karaoke, and raised two down-to-earth daughters under an unforgiving media glare." ,
                Editorial = "#1 NEW YORK TIMES BESTSELLER • WATCH THE NETFLIX ORIGINAL DOCUMENTARY • OPRAH’S BOOK CLUB PICK • NAACP IMAGE AWARD WINNER",
                Ratings = 4.7,
                Review = null

            }

          );

            modelBuilder.Entity<Details>().HasData(new Details
            {
                Id = 3,
                Description = "In this “vital, necessary, and beautiful book” (Michael Eric Dyson), antiracist educator Robin DiAngelo deftly illuminates the phenomenon of white fragility and"+
                "“allows us to understand racism as a practice not restricted to ‘bad people’ (Claudia Rankine). Referring to the defensive moves that white people make when challenged racially, white fragility is characterized by emotions such as anger, fear, and guilt, and by behaviors including argumentation and silence." +
                "These behaviors, in turn, function to reinstate white racial equilibrium and prevent any meaningful cross-racial dialogue. In this in-depth exploration, DiAngelo examines how white fragility develops, how it protects racial inequality, and what we can do to engage more constructively.",
                Editorial = "The New York Times best-selling book exploring the counterproductive reactions white people have when their assumptions about race are challenged, and how these reactions maintain racial inequality",
                Ratings = 4.3,
                Review = null

            }

          );

            modelBuilder.Entity<Details>().HasData(new Details
            {
                Id = 4,
                Description = "Push your limits, reflect on your past, present, and future, and create a secret book that’s about you, and just for you. And when you’re finished, toss it, hide it, or Burn After Writing.",
                Editorial = null,
                Ratings = 4.7,
                Review = null

            }

          );

            modelBuilder.Entity<Details>().HasData(new Details
            {
                Id = 5,
                Description = "Widespread reporting on aspects of white supremacy--from police brutality to the mass incarceration of Black Americans--has put a media spotlight on racism in our society. Still, it is a difficult subject to talk about. How do you tell your roommate her jokes are racist? Why did your sister-in-law take umbrage when you asked to touch her hair--and how do you make it right? How do you explain white privilege to your white, privileged friend?"+
                "In So You Want to Talk About Race,Ijeoma Oluo guides readers of all races through subjects ranging from intersectionality and affirmative action to "+"model minorities in an attempt to make the seemingly impossible possible: honest conversations about race and racism," +
                "and how they infect almost every aspect of American life",
                
                Editorial = "\"Oluo gives us--both white people and people of color--that language to engage in clear, constructiv and confident dialogue with each other about how to deal with racial prejudices and biases.\" +" +
                "--National Book Review,",

                Ratings = 4.7,
                Review = null

            }

          );

        }
    }
}
