using Microsoft.EntityFrameworkCore.Migrations;

namespace _2UrDoorBakery.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakery",
                columns: table => new
                {
                    BakeryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakery", x => x.BakeryId);
                });

            migrationBuilder.InsertData(
                table: "Bakery",
                columns: new[] { "BakeryId", "Description", "ImageThumbnailUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "3D Bear Cake made with Gelatine and Cream Cheese, along with candy and marshmallow!", "https://zhwebproject.blob.core.windows.net/files/3DBearCake1.JPG", "3D Bear Cake with Letter", 28.50m },
                    { 2, "3D Bear Cake made with Gelatine and Cream Cheese!", "https://zhwebproject.blob.core.windows.net/files/3DBearCake2.jpg", "3D Bear Cake with Pink Bow Tie", 25.50m },
                    { 3, "Fresh Banana with delicious walnut!", "https://zhwebproject.blob.core.windows.net/files/BananaNutBread.JPG", "Banana Nut Bread", 4.50m },
                    { 4, "This price comes with 4 cute bunny hot dogs.", "https://zhwebproject.blob.core.windows.net/files/BunnyHotDog.JPG", "Bunny Hot Dogs", 9.50m },
                    { 5, "Chocolate cake with chocolate cream!", "https://zhwebproject.blob.core.windows.net/files/ChocolateCreamRoll.JPG", "Chocolate Cream Roll", 8.95m },
                    { 6, "Fresh Home-made Butter Croissant.", "https://zhwebproject.blob.core.windows.net/files/Croissant1.JPG", "Butter Croissant", 1.95m },
                    { 7, "A Must Try Roll if you haven't tried yet", "https://zhwebproject.blob.core.windows.net/files/PorkFlossRoll.JPG", "Pork Floss Roll", 9.95m },
                    { 8, "Nothing is better than a cream cake with Strawberries!", "https://zhwebproject.blob.core.windows.net/files/StrawberryCake1.jpg", "Strawberry Cream Cake", 15.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bakery");
        }
    }
}
