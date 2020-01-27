using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS_Data.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Revature");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                schema: "Revature",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    age = table.Column<int>(nullable: true),
                    startdate = table.Column<DateTime>(nullable: true),
                    salary = table.Column<decimal>(nullable: true),
                    ssn = table.Column<string>(nullable: true),
                    Deptid = table.Column<int>(nullable: true),
                    Fname = table.Column<string>(maxLength: 30, nullable: false),
                    Lname = table.Column<string>(maxLength: 30, nullable: false),
                    Mname = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.id);
                    table.ForeignKey(
                        name: "FK_employee_Department_Deptid",
                        column: x => x.Deptid,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 1, "Training", "7894561230" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 2, "HR", "9876543210" });

            migrationBuilder.InsertData(
                schema: "Revature",
                table: "employee",
                columns: new[] { "id", "age", "Deptid", "Fname", "Lname", "Mname", "salary", "ssn", "startdate" },
                values: new object[] { 1, 35, 1, "Fred", "Belotte", null, 11000.00m, "789kl45", new DateTime(2020, 1, 24, 12, 38, 44, 942, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.InsertData(
                schema: "Revature",
                table: "employee",
                columns: new[] { "id", "age", "Deptid", "Fname", "Lname", "Mname", "salary", "ssn", "startdate" },
                values: new object[] { 2, 25, 2, "Cameron", "Coley", null, 5000.00m, "745kl65", new DateTime(2020, 1, 24, 12, 38, 44, 947, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.CreateIndex(
                name: "IX_employee_Deptid",
                schema: "Revature",
                table: "employee",
                column: "Deptid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee",
                schema: "Revature");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
