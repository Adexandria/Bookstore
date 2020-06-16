using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Ratings = table.Column<double>(nullable: false),
                    Editorial = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DescriptionId = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Detail_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "DescriptionId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Delia Owens", null, "https://images-na.ssl-images-amazon.com/images/I/51NYjNgldSL._SX330_BO1,204,203,200_.jpg", "Where the Crawdads Sing", 14.300000000000001 },
                    { 2, "Michelle Obama", null, "https://images-na.ssl-images-amazon.com/images/I/414JfiBCutL._SX327_BO1,204,203,200_.jpg", "Becoming", 11.890000000000001 },
                    { 3, "Robin DiAngelo", null, "https://images-na.ssl-images-amazon.com/images/I/51aDh-YMFAL._SX331_BO1,204,203,200_.jpg", "White Fragility: Why It's So Hard for White People to Talk About Racism", 12.24 },
                    { 4, "Sharon Jones", null, "https://images-na.ssl-images-amazon.com/images/I/51OelfoY-ML._SX330_BO1,204,203,200_.jpg", "Burn After Writing", 8.4000000000000004 },
                    { 5, "Ijeoma Oluo", null, "https://images-na.ssl-images-amazon.com/images/I/41XIlsrvpIL._SX331_BO1,204,203,200_.jpg", "So You Want to Talk About Race", 27.0 }
                });

            migrationBuilder.InsertData(
                table: "Detail",
                columns: new[] { "Id", "Description", "Editorial", "Ratings", "Review" },
                values: new object[,]
                {
                    { 1, "For years, rumors of the Marsh Girl have haunted Barkley Cove, a quiet town on the North Carolina coast. So in late 1969, when handsome Chase Andrews is found dead, the locals immediately suspect Kya Clark, the so-called Marsh Girl. But Kya is not what they say. Sensitive and intelligent, she has survived for years alone in the marsh that she calls home, finding friends in the gulls and lessons in the sandThen the time comes when she yearns to be touched and loved. When two young men from town become intrigued by her wild beauty, Kya opens herself to a new life--until the unthinkable happens.", "\"I can't even express how much I love this book! I didn't want this story to end!\"--Reese Witherspoon\"Painfully beautiful.\"--The New York Times Book Review", 4.7999999999999998, null },
                    { 2, "In a life filled with meaning and accomplishment, Michelle Obama has emerged as one of the most iconic and compelling women of our era.As First Lady of the United States of America—the first African American to serve in that role—she helped create the most welcoming and inclusive White House in history, while also establishing herself as a powerful advocate for women and girls in the U.S. and around the world, dramatically changing the ways that families pursue healthier and more active lives, and standing with her husband as he led America through some of its most harrowing moments. Along the way, she showed us a few dance moves, crushed Carpool Karaoke, and raised two down-to-earth daughters under an unforgiving media glare.", "#1 NEW YORK TIMES BESTSELLER • WATCH THE NETFLIX ORIGINAL DOCUMENTARY • OPRAH’S BOOK CLUB PICK • NAACP IMAGE AWARD WINNER", 4.7000000000000002, null },
                    { 3, "In this “vital, necessary, and beautiful book” (Michael Eric Dyson), antiracist educator Robin DiAngelo deftly illuminates the phenomenon of white fragility and“allows us to understand racism as a practice not restricted to ‘bad people’ (Claudia Rankine). Referring to the defensive moves that white people make when challenged racially, white fragility is characterized by emotions such as anger, fear, and guilt, and by behaviors including argumentation and silence.These behaviors, in turn, function to reinstate white racial equilibrium and prevent any meaningful cross-racial dialogue. In this in-depth exploration, DiAngelo examines how white fragility develops, how it protects racial inequality, and what we can do to engage more constructively.", "The New York Times best-selling book exploring the counterproductive reactions white people have when their assumptions about race are challenged, and how these reactions maintain racial inequality", 4.2999999999999998, null },
                    { 4, "Push your limits, reflect on your past, present, and future, and create a secret book that’s about you, and just for you. And when you’re finished, toss it, hide it, or Burn After Writing.", null, 4.7000000000000002, null },
                    { 5, "Widespread reporting on aspects of white supremacy--from police brutality to the mass incarceration of Black Americans--has put a media spotlight on racism in our society. Still, it is a difficult subject to talk about. How do you tell your roommate her jokes are racist? Why did your sister-in-law take umbrage when you asked to touch her hair--and how do you make it right? How do you explain white privilege to your white, privileged friend?In So You Want to Talk About Race,Ijeoma Oluo guides readers of all races through subjects ranging from intersectionality and affirmative action to model minorities in an attempt to make the seemingly impossible possible: honest conversations about race and racism,and how they infect almost every aspect of American life", "\"Oluo gives us--both white people and people of color--that language to engage in clear, constructiv and confident dialogue with each other about how to deal with racial prejudices and biases.\" +--National Book Review,", 4.7000000000000002, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_DescriptionId",
                table: "Book",
                column: "DescriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Detail");
        }
    }
}
