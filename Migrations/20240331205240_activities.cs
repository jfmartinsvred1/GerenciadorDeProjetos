using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gerenciador.Migrations
{
    /// <inheritdoc />
    public partial class activities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_AspNetUsers_UserId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Projects_ProjectId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_States_StateId",
                table: "Activity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activity",
                table: "Activity");

            migrationBuilder.RenameTable(
                name: "Activity",
                newName: "Activities");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_UserId",
                table: "Activities",
                newName: "IX_Activities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_StateId",
                table: "Activities",
                newName: "IX_Activities_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_ProjectId",
                table: "Activities",
                newName: "IX_Activities_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_AspNetUsers_UserId",
                table: "Activities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Projects_ProjectId",
                table: "Activities",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_States_StateId",
                table: "Activities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_AspNetUsers_UserId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Projects_ProjectId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_States_StateId",
                table: "Activities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "Activity");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_UserId",
                table: "Activity",
                newName: "IX_Activity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_StateId",
                table: "Activity",
                newName: "IX_Activity_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_ProjectId",
                table: "Activity",
                newName: "IX_Activity_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activity",
                table: "Activity",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_AspNetUsers_UserId",
                table: "Activity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Projects_ProjectId",
                table: "Activity",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_States_StateId",
                table: "Activity",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId");
        }
    }
}
