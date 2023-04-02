using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTemplate.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "forecasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateTimeAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false),
                    summary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forecasts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "forecasts",
                columns: new[] { "Id", "DateTimeAt", "summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 3, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", 54 },
                    { 2, new DateTime(2023, 4, 4, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", 32 },
                    { 3, new DateTime(2023, 4, 5, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", 16 },
                    { 4, new DateTime(2023, 4, 6, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", -20 },
                    { 5, new DateTime(2023, 4, 7, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", -2 },
                    { 6, new DateTime(2023, 4, 8, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", -4 },
                    { 7, new DateTime(2023, 4, 9, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", -12 },
                    { 8, new DateTime(2023, 4, 10, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 43 },
                    { 9, new DateTime(2023, 4, 11, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", -18 },
                    { 10, new DateTime(2023, 4, 12, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", 27 },
                    { 11, new DateTime(2023, 4, 13, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", 12 },
                    { 12, new DateTime(2023, 4, 14, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 36 },
                    { 13, new DateTime(2023, 4, 15, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Mild", 39 },
                    { 14, new DateTime(2023, 4, 16, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Balmy", 53 },
                    { 15, new DateTime(2023, 4, 17, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Bracing", -17 },
                    { 16, new DateTime(2023, 4, 18, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", -14 },
                    { 17, new DateTime(2023, 4, 19, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", 11 },
                    { 18, new DateTime(2023, 4, 20, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 41 },
                    { 19, new DateTime(2023, 4, 21, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", 5 },
                    { 20, new DateTime(2023, 4, 22, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 46 },
                    { 21, new DateTime(2023, 4, 23, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", 54 },
                    { 22, new DateTime(2023, 4, 24, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Mild", 52 },
                    { 23, new DateTime(2023, 4, 25, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Balmy", 33 },
                    { 24, new DateTime(2023, 4, 26, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", -12 },
                    { 25, new DateTime(2023, 4, 27, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 41 },
                    { 26, new DateTime(2023, 4, 28, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", -14 },
                    { 27, new DateTime(2023, 4, 29, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", 23 },
                    { 28, new DateTime(2023, 4, 30, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", 44 },
                    { 29, new DateTime(2023, 5, 1, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", 7 },
                    { 30, new DateTime(2023, 5, 2, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 40 },
                    { 31, new DateTime(2023, 5, 3, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 15 },
                    { 32, new DateTime(2023, 5, 4, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Balmy", -6 },
                    { 33, new DateTime(2023, 5, 5, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Mild", 6 },
                    { 34, new DateTime(2023, 5, 6, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", -8 },
                    { 35, new DateTime(2023, 5, 7, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", 4 },
                    { 36, new DateTime(2023, 5, 8, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", -15 },
                    { 37, new DateTime(2023, 5, 9, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 13 },
                    { 38, new DateTime(2023, 5, 10, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Balmy", -1 },
                    { 39, new DateTime(2023, 5, 11, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", 23 },
                    { 40, new DateTime(2023, 5, 12, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", -13 },
                    { 41, new DateTime(2023, 5, 13, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 13 },
                    { 42, new DateTime(2023, 5, 14, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Bracing", -3 },
                    { 43, new DateTime(2023, 5, 15, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", 40 },
                    { 44, new DateTime(2023, 5, 16, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", -7 },
                    { 45, new DateTime(2023, 5, 17, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", 37 },
                    { 46, new DateTime(2023, 5, 18, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", -12 },
                    { 47, new DateTime(2023, 5, 19, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", -6 },
                    { 48, new DateTime(2023, 5, 20, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", 8 },
                    { 49, new DateTime(2023, 5, 21, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 14 },
                    { 50, new DateTime(2023, 5, 22, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 49 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "forecasts");
        }
    }
}
