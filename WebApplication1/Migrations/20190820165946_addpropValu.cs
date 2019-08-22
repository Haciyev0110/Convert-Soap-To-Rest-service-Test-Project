using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class addpropValu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_secondTables_firstTables_firstTableId",
                table: "secondTables");

            migrationBuilder.RenameColumn(
                name: "firstTableId",
                table: "secondTables",
                newName: "FirstTableId");

            migrationBuilder.RenameColumn(
                name: "FirstTabelID",
                table: "secondTables",
                newName: "FirstTabelId");

            migrationBuilder.RenameIndex(
                name: "IX_secondTables_firstTableId",
                table: "secondTables",
                newName: "IX_secondTables_FirstTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_secondTables_firstTables_FirstTableId",
                table: "secondTables",
                column: "FirstTableId",
                principalTable: "firstTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_secondTables_firstTables_FirstTableId",
                table: "secondTables");

            migrationBuilder.RenameColumn(
                name: "FirstTableId",
                table: "secondTables",
                newName: "firstTableId");

            migrationBuilder.RenameColumn(
                name: "FirstTabelId",
                table: "secondTables",
                newName: "FirstTabelID");

            migrationBuilder.RenameIndex(
                name: "IX_secondTables_FirstTableId",
                table: "secondTables",
                newName: "IX_secondTables_firstTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_secondTables_firstTables_firstTableId",
                table: "secondTables",
                column: "firstTableId",
                principalTable: "firstTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
