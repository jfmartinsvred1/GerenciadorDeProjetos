using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gerenciador.Migrations
{
    /// <inheritdoc />
    public partial class activity_states : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StateId",
                table: "States",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "StateId",
                table: "Activity",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_StateId",
                table: "Activity",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_States_StateId",
                table: "Activity",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_States_StateId",
                table: "Activity");

            migrationBuilder.DropIndex(
                name: "IX_Activity_StateId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Activity");

            migrationBuilder.AlterColumn<Guid>(
                name: "StateId",
                table: "States",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
