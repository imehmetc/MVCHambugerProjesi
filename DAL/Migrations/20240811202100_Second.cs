using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 23, 20, 59, 462, DateTimeKind.Local).AddTicks(2585));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 20, 17, 41, 745, DateTimeKind.Local).AddTicks(6736));
        }
    }
}
