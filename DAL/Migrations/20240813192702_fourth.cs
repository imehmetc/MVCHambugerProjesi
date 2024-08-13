using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "ExtraItemId",
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
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ExtraItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "MenuDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 22, 27, 0, 385, DateTimeKind.Local).AddTicks(417));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExtraItemId",
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
    }
}
