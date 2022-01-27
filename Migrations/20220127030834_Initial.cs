﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace mission04.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent", "note", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "Peter Ramsey, Bob Persichetti, Rodney Rothman", false, "", "", "PG", "Spiderman:Into the Spider-Verse", 2018 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent", "note", "rating", "title", "year" },
                values: new object[] { 2, "Drama", "Frank Darabont", true, "", "", "R", "Shawshank Redemption, The", 1994 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent", "note", "rating", "title", "year" },
                values: new object[] { 3, "Family", "Lee Unkrich", false, "", "", "G", "Toy Story 3", 2010 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
