using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthyCalorie.UserFood.Storage.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "UserFood");

            migrationBuilder.CreateTable(
                name: "Nutrients",
                schema: "UserFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UnitName = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFoodCategories",
                schema: "UserFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFoods",
                schema: "UserFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataType = table.Column<string>(type: "TEXT", nullable: true),
                    FoodCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    UserFoodCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFoods_UserFoodCategories_UserFoodCategoryId",
                        column: x => x.UserFoodCategoryId,
                        principalSchema: "UserFood",
                        principalTable: "UserFoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFoodNutrients",
                schema: "UserFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    NutrientId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<float>(type: "REAL", nullable: false),
                    UserFoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoodNutrients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFoodNutrients_Nutrients_NutrientId",
                        column: x => x.NutrientId,
                        principalSchema: "UserFood",
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoodNutrients_UserFoods_UserFoodId",
                        column: x => x.UserFoodId,
                        principalSchema: "UserFood",
                        principalTable: "UserFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodNutrients_NutrientId",
                schema: "UserFood",
                table: "UserFoodNutrients",
                column: "NutrientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodNutrients_UserFoodId",
                schema: "UserFood",
                table: "UserFoodNutrients",
                column: "UserFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_UserFoodCategoryId",
                schema: "UserFood",
                table: "UserFoods",
                column: "UserFoodCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFoodNutrients",
                schema: "UserFood");

            migrationBuilder.DropTable(
                name: "Nutrients",
                schema: "UserFood");

            migrationBuilder.DropTable(
                name: "UserFoods",
                schema: "UserFood");

            migrationBuilder.DropTable(
                name: "UserFoodCategories",
                schema: "UserFood");
        }
    }
}
