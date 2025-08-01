﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eva_Pharma_Task1.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BookPrice = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "BookPrice", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", 1, "This is the description of Book 1", 10.0, "Book 1" },
                    { 2, "Author 2", 2, "This is the description of Book 2", 20.0, "Book 2" },
                    { 3, "Author 3", 3, "This is the description of Book 3", 30.0, "Book 3" },
                    { 4, "Author 4", 4, "This is the description of Book 4", 40.0, "Book 4" },
                    { 5, "Author 5", 5, "This is the description of Book 5", 50.0, "Book 5" },
                    { 6, "Author 6", 6, "This is the description of Book 6", 60.0, "Book 6" },
                    { 7, "Author 7", 7, "This is the description of Book 7", 70.0, "Book 7" },
                    { 8, "Author 8", 8, "This is the description of Book 8", 80.0, "Book 8" },
                    { 9, "Author 9", 9, "This is the description of Book 9", 90.0, "Book 9" },
                    { 10, "Author 10", 10, "This is the description of Book 10", 100.0, "Book 10" },
                    { 11, "Author 11", 11, "This is the description of Book 11", 110.0, "Book 11" },
                    { 12, "Author 12", 12, "This is the description of Book 12", 120.0, "Book 12" },
                    { 13, "Author 13", 13, "This is the description of Book 13", 130.0, "Book 13" },
                    { 14, "Author 14", 14, "This is the description of Book 14", 140.0, "Book 14" },
                    { 15, "Author 15", 15, "This is the description of Book 15", 150.0, "Book 15" },
                    { 16, "Author 16", 16, "This is the description of Book 16", 160.0, "Book 16" },
                    { 17, "Author 17", 17, "This is the description of Book 17", 170.0, "Book 17" },
                    { 18, "Author 18", 18, "This is the description of Book 18", 180.0, "Book 18" },
                    { 19, "Author 19", 19, "This is the description of Book 19", 190.0, "Book 19" },
                    { 20, "Author 20", 20, "This is the description of Book 20", 200.0, "Book 20" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
