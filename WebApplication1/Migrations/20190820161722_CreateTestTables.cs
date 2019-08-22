using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CreateTestTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "firstTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Insert_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firstTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "secondTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Insert_Date = table.Column<DateTime>(nullable: false),
                    firstTableId = table.Column<int>(nullable: true),
                    FirstTabelID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secondTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_secondTables_firstTables_firstTableId",
                        column: x => x.firstTableId,
                        principalTable: "firstTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_secondTables_firstTableId",
                table: "secondTables",
                column: "firstTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "secondTables");

            migrationBuilder.DropTable(
                name: "firstTables");
        }
    }
}
