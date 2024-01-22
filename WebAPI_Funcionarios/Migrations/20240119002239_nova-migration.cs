using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_Funcionarios.Migrations
{
    /// <inheritdoc />
    public partial class novamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Funcionarios",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Funcionarios",
                newName: "Name");
        }
    }
}
