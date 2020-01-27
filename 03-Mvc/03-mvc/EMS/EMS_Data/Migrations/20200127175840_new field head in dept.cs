using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS_Data.Migrations
{
    public partial class newfieldheadindept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Head",
                table: "Department",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Revature",
                table: "employee",
                keyColumn: "id",
                keyValue: 1,
                column: "startdate",
                value: new DateTime(2020, 1, 27, 11, 58, 39, 717, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                schema: "Revature",
                table: "employee",
                keyColumn: "id",
                keyValue: 2,
                column: "startdate",
                value: new DateTime(2020, 1, 27, 11, 58, 39, 720, DateTimeKind.Local).AddTicks(9388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Head",
                table: "Department");

            migrationBuilder.UpdateData(
                schema: "Revature",
                table: "employee",
                keyColumn: "id",
                keyValue: 1,
                column: "startdate",
                value: new DateTime(2020, 1, 24, 12, 38, 44, 942, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                schema: "Revature",
                table: "employee",
                keyColumn: "id",
                keyValue: 2,
                column: "startdate",
                value: new DateTime(2020, 1, 24, 12, 38, 44, 947, DateTimeKind.Local).AddTicks(85));
        }
    }
}
