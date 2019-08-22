using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class addpropVal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_secondTables_firstTables_FirstTableId",
                table: "secondTables");

            migrationBuilder.DropColumn(
                name: "FirstTabelId",
                table: "secondTables");

            migrationBuilder.AlterColumn<int>(
                name: "FirstTableId",
                table: "secondTables",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_secondTables_firstTables_FirstTableId",
                table: "secondTables",
                column: "FirstTableId",
                principalTable: "firstTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_secondTables_firstTables_FirstTableId",
                table: "secondTables");

            migrationBuilder.AlterColumn<int>(
                name: "FirstTableId",
                table: "secondTables",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FirstTabelId",
                table: "secondTables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_secondTables_firstTables_FirstTableId",
                table: "secondTables",
                column: "FirstTableId",
                principalTable: "firstTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
