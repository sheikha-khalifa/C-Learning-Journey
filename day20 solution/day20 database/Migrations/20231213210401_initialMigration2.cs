using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace day20_database.Migrations
{
    public partial class initialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee2_department2_depId",
                table: "employee2");

            migrationBuilder.AlterColumn<int>(
                name: "EmpId",
                table: "Project2",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "projId",
                table: "employee2",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "depId",
                table: "employee2",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_employee2_department2_depId",
                table: "employee2",
                column: "depId",
                principalTable: "department2",
                principalColumn: "DpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee2_department2_depId",
                table: "employee2");

            migrationBuilder.AlterColumn<int>(
                name: "EmpId",
                table: "Project2",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "projId",
                table: "employee2",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "depId",
                table: "employee2",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_employee2_department2_depId",
                table: "employee2",
                column: "depId",
                principalTable: "department2",
                principalColumn: "DpId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
