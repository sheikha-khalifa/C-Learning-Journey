using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace day20_database.Migrations
{
    public partial class initialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "depId",
                table: "employee2",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "projId",
                table: "employee2",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Project2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesProjects",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    ProjectsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesProjects", x => new { x.EmployeesID, x.ProjectsID });
                    table.ForeignKey(
                        name: "FK_EmployeesProjects_employee2_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "employee2",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesProjects_Project2_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "Project2",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employee2_depId",
                table: "employee2",
                column: "depId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesProjects_ProjectsID",
                table: "EmployeesProjects",
                column: "ProjectsID");

            migrationBuilder.AddForeignKey(
                name: "FK_employee2_department2_depId",
                table: "employee2",
                column: "depId",
                principalTable: "department2",
                principalColumn: "DpId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee2_department2_depId",
                table: "employee2");

            migrationBuilder.DropTable(
                name: "EmployeesProjects");

            migrationBuilder.DropTable(
                name: "Project2");

            migrationBuilder.DropIndex(
                name: "IX_employee2_depId",
                table: "employee2");

            migrationBuilder.DropColumn(
                name: "depId",
                table: "employee2");

            migrationBuilder.DropColumn(
                name: "projId",
                table: "employee2");
        }
    }
}
