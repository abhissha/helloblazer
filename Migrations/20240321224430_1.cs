using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestAutomation.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestCase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestCaseInput",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestCaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCaseInput", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestCaseInput_TestCase_TestCaseId",
                        column: x => x.TestCaseId,
                        principalTable: "TestCase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestCaseOutput",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestCaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCaseOutput", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestCaseOutput_TestCase_TestCaseId",
                        column: x => x.TestCaseId,
                        principalTable: "TestCase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestCaseRunHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestCaseId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RunDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCaseRunHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestCaseRunHistory_TestCase_TestCaseId",
                        column: x => x.TestCaseId,
                        principalTable: "TestCase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseInput_TestCaseId",
                table: "TestCaseInput",
                column: "TestCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseOutput_TestCaseId",
                table: "TestCaseOutput",
                column: "TestCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseRunHistory_TestCaseId",
                table: "TestCaseRunHistory",
                column: "TestCaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestCaseInput");

            migrationBuilder.DropTable(
                name: "TestCaseOutput");

            migrationBuilder.DropTable(
                name: "TestCaseRunHistory");

            migrationBuilder.DropTable(
                name: "TestCase");
        }
    }
}
