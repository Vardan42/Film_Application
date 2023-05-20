using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Film_Application.Migrations
{
    /// <inheritdoc />
    public partial class CategoryForMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Janre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    NameComapany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileCraetedData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CategoryData",
                columns: new[] { "Id", "Janre" },
                values: new object[,]
                {
                    { 1, "Drama" },
                    { 2, "Cartoon" },
                    { 3, "Documentary" },
                    { 4, "Horror" },
                    { 5, "Action" },
                    { 6, "Documentary" }
                });

            migrationBuilder.InsertData(
                table: "FileData",
                columns: new[] { "Id", "Count", "Description", "FileCraetedData", "Image", "Name", "NameComapany", "Price" },
                values: new object[,]
                {
                    { 1, 23, "This is the Life movie description", new DateTime(2002, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://pbs.twimg.com/media/DBlhtBmXoAAj-j2?format=jpg&name=large", "Life", "ComanyName1", 390 },
                    { 2, 13, "This is the Shawshank Redemption description", new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg", "The Shawshank Redemption", "ComanyName2", 45 },
                    { 3, 23, "This is the Ghost movie description", new DateTime(2009, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/71-HovwGgJL._AC_UF1000,1000_QL80_.jpg", "Ghost", "ComanyName3", 454 },
                    { 4, 13, "This is the Race movie description", new DateTime(2011, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/M/MV5BMTQ3MDM1MDU2NF5BMl5BanBnXkFtZTgwMzM3OTIzNzE@._V1_.jpg", "Race", "ComanyName4", 32 },
                    { 5, 13, "This is the Scoob movie description", new DateTime(2011, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://parentpreviews.com/images/made/legacy-pics/scoob-5_668_330_80_int_s_c1.jpg", "Scoob", "ComanyName5", 390 },
                    { 6, 22, "This is the Cold Soles movie description", new DateTime(2011, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/M/MV5BOWI2MTFmMjAtNjM1ZC00ZGNhLWJjNWQtOWMwZDI3MzYxOTQwXkEyXkFqcGdeQXVyMjIxNTg0MDQ@._V1_.jpg", "Cold Soles", "NameCompany6", 390 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryData");

            migrationBuilder.DropTable(
                name: "FileData");
        }
    }
}
