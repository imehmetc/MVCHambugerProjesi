using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExtraItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalPrice = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCount = table.Column<int>(type: "int", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraItemId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuDetails_ExtraItems_ExtraItemId",
                        column: x => x.ExtraItemId,
                        principalTable: "ExtraItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MenuDetails_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderSize = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ExtraItemId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ExtraItems_ExtraItemId",
                        column: x => x.ExtraItemId,
                        principalTable: "ExtraItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ExtraItems",
                columns: new[] { "Id", "AdditionalPrice", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1.0, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7002), null, false, null, "Cheese" },
                    { 2, 1.5, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7004), null, false, null, "Bacon" },
                    { 3, 1.25, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7006), null, false, null, "Mushrooms" },
                    { 4, 2.0, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7007), null, false, null, "Avocado" },
                    { 5, 0.75, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7009), null, false, null, "Onions" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "IsDeleted", "ModifiedDate", "Name", "OrderCount", "Photo", "Price", "ViewCount" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7048), null, "Juicy beef burger", false, null, "Burger", 10, null, 8.9900000000000002, 50 },
                    { 2, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7051), null, "Cheese and pepperoni", false, null, "Pizza", 20, null, 12.99, 100 },
                    { 3, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7053), null, "Creamy Alfredo pasta", false, null, "Pasta", 15, null, 10.99, 75 },
                    { 4, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7055), null, "Fresh garden salad", false, null, "Salad", 8, null, 7.9900000000000002, 40 },
                    { 5, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7057), null, "Spicy chicken tacos", false, null, "Tacos", 12, null, 9.9900000000000002, 60 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "Email", "FirstName", "IsAdmin", "IsDeleted", "LastName", "ModifiedDate", "Password", "Photo", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6724), null, "admin@example.com", "Admin", true, false, "User", null, "admin123", null, "admin" },
                    { 2, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6727), null, "john@example.com", "John", false, false, "Doe", null, "password123", null, "john" },
                    { 3, new DateTime(1985, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6731), null, "jane@example.com", "Jane", false, false, "Smith", null, "password123", null, "jane" },
                    { 4, new DateTime(1975, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6733), null, "michael@example.com", "Michael", false, false, "Brown", null, "password123", null, "michael" },
                    { 5, new DateTime(1995, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6736), null, "emily@example.com", "Emily", false, false, "Clark", null, "password123", null, "emily" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "DeletedDate", "FullAddress", "IsDeleted", "ModifiedDate", "PostalCode", "UserId" },
                values: new object[,]
                {
                    { 1, "New York", "USA", new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6956), null, "123 Main St", false, null, 10001, 2 },
                    { 2, "Los Angeles", "USA", new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6959), null, "456 Elm St", false, null, 90001, 3 },
                    { 3, "Chicago", "USA", new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6961), null, "789 Pine St", false, null, 60007, 4 },
                    { 4, "Houston", "USA", new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6963), null, "321 Oak St", false, null, 77001, 5 },
                    { 5, "Phoenix", "USA", new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6965), null, "654 Maple St", false, null, 85001, 2 }
                });

            migrationBuilder.InsertData(
                table: "MenuDetails",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "ExtraItemId", "IsDeleted", "MenuId", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7094), null, 1, false, 1, null },
                    { 2, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7097), null, 2, false, 2, null },
                    { 3, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7098), null, 3, false, 3, null },
                    { 4, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7100), null, 4, false, 4, null },
                    { 5, new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7101), null, 5, false, 5, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetails_ExtraItemId",
                table: "MenuDetails",
                column: "ExtraItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetails_MenuId",
                table: "MenuDetails",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_AddressId",
                table: "OrderDetails",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ExtraItemId",
                table: "OrderDetails",
                column: "ExtraItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MenuId",
                table: "OrderDetails",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ExtraItems");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
