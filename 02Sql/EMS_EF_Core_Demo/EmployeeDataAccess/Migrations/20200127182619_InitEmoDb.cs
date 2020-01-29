using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeDataAccess.Migrations
{
    public partial class InitEmoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Revature");

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "Revature",
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
                name: "Employee",
                schema: "Revature",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(nullable: true),
                    Startdate = table.Column<DateTime>(nullable: true),
                    Salary = table.Column<decimal>(nullable: true),
                    Ssn = table.Column<string>(nullable: true),
                    Deptid = table.Column<int>(nullable: true),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    Mname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Department_Deptid",
                        column: x => x.Deptid,
                        principalSchema: "Revature",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Revature",
                table: "Department",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 1, "R&D", "765432190" });

            migrationBuilder.InsertData(
                schema: "Revature",
                table: "Employee",
                columns: new[] { "Id", "Age", "Deptid", "Fname", "Lname", "Mname", "Salary", "Ssn", "Startdate" },
                values: new object[] { 1, 32, 1, "Pushpinder", "Kaur", null, 15000.00m, "767875791", new DateTime(2019, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Deptid",
                schema: "Revature",
                table: "Employee",
                column: "Deptid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee",
                schema: "Revature");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "Revature");
        }
    }
}
