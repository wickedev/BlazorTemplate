using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorTemplate.Migrations
{
    /// <inheritdoc />
    public partial class _01_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 18, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Warm", -4 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 19, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Hot", 0 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 20, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Hot", -1 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 21, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Hot", 20 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 22, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Balmy", -20 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Balmy", 54 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 24, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), 35 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 25, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Chilly", 5 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 26, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Hot", 41 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 27, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Hot", 12 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 28, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Chilly", 47 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 29, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Bracing", -15 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 6, 30, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), 53 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 1, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Freezing", 38 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 2, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Warm", 50 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Sweltering", 12 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 4, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Sweltering", 28 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Sweltering", -5 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 6, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Warm", 46 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 7, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Sweltering", 35 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 8, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Scorching", 3 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 9, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Cool", 50 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 10, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Cool", -8 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 11, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Chilly", 18 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTimeAt", "summary" },
                values: new object[] { new DateTime(2023, 7, 12, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Mild" });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 13, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Mild", 33 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 14, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Scorching", 25 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 15, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Scorching", 7 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 16, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Scorching", -15 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 17, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Freezing", -9 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 18, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Warm", 6 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 19, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), 49 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 20, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Freezing", 53 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Warm", 2 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 22, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Sweltering", 47 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Scorching", 0 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 24, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Sweltering", -16 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 25, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Mild", 34 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 26, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Balmy", 30 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 27, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Bracing", 22 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 28, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Scorching", 9 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 29, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Scorching", -11 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 30, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Cool", -7 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 7, 31, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Bracing", 35 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 8, 1, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), 34 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 8, 2, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Cool", -2 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Balmy", -3 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 8, 4, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Freezing", 13 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 8, 5, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), 13 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 8, 6, 11, 3, 50, 657, DateTimeKind.Utc).AddTicks(3060), "Balmy", 8 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 3, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", 54 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 4, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", 32 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", 16 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 6, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", -20 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 7, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", -2 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", -4 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 9, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), -12 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 10, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 43 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 11, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", -18 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 12, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", 27 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 13, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", 12 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 14, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 36 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 15, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), 39 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 16, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Balmy", 53 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 17, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Bracing", -17 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", -14 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 19, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", 11 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 20, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 41 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 21, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", 5 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 22, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 46 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", 54 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 24, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Mild", 52 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 25, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Balmy", 33 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 26, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", -12 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTimeAt", "summary" },
                values: new object[] { new DateTime(2023, 4, 27, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching" });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 28, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", -14 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 29, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", 23 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 4, 30, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", 44 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 1, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", 7 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 2, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 40 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 3, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 15 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 4, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), -6 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 5, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Mild", 6 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 6, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Cool", -8 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 7, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", 4 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 8, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", -15 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 9, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 13 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 10, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Balmy", -1 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 11, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", 23 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 12, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", -13 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 13, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Hot", 13 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 14, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Bracing", -3 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", 40 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 16, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Freezing", -7 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), 37 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 18, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Warm", -12 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 19, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Sweltering", -6 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 20, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Chilly", 8 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateTimeAt", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 21, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), 14 });

            migrationBuilder.UpdateData(
                table: "forecasts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateTimeAt", "summary", "TemperatureC" },
                values: new object[] { new DateTime(2023, 5, 22, 16, 40, 20, 551, DateTimeKind.Utc).AddTicks(1870), "Scorching", 49 });
        }
    }
}
