using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 23, 42, 89, DateTimeKind.Local).AddTicks(7957));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
