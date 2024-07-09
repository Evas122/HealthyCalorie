CREATE TABLE "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "FoodCategories" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_FoodCategories" PRIMARY KEY AUTOINCREMENT,
    "Description" TEXT NULL,
    "CreatedAt" TEXT NOT NULL,
    "UpdatedAt" TEXT NOT NULL
);

CREATE TABLE "Nutrients" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Nutrients" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NULL,
    "UnitName" TEXT NULL,
    "CreatedAt" TEXT NOT NULL,
    "UpdatedAt" TEXT NOT NULL
);

CREATE TABLE "Foods" (
    "FdcId" INTEGER NOT NULL CONSTRAINT "PK_Foods" PRIMARY KEY AUTOINCREMENT,
    "DataType" TEXT NULL,
    "FoodCategoryId" INTEGER NOT NULL,
    "Description" TEXT NULL,
    CONSTRAINT "FK_Foods_FoodCategories_FoodCategoryId" FOREIGN KEY ("FoodCategoryId") REFERENCES "FoodCategories" ("Id") ON DELETE CASCADE
);

CREATE TABLE "FoodNutrients" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_FoodNutrients" PRIMARY KEY AUTOINCREMENT,
    "FdcId" INTEGER NOT NULL,
    "NutrientId" INTEGER NOT NULL,
    "Amount" REAL NOT NULL,
    "FoodFdcId" INTEGER NOT NULL,
    CONSTRAINT "FK_FoodNutrients_Foods_FoodFdcId" FOREIGN KEY ("FoodFdcId") REFERENCES "Foods" ("FdcId") ON DELETE CASCADE,
    CONSTRAINT "FK_FoodNutrients_Nutrients_NutrientId" FOREIGN KEY ("NutrientId") REFERENCES "Nutrients" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_FoodNutrients_FoodFdcId" ON "FoodNutrients" ("FoodFdcId");

CREATE INDEX "IX_FoodNutrients_NutrientId" ON "FoodNutrients" ("NutrientId");

CREATE INDEX "IX_Foods_FoodCategoryId" ON "Foods" ("FoodCategoryId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240708124323_InitialCreate', '7.0.0');

COMMIT;

