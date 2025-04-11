using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject.Infraustraction.Migrations
{
    /// <inheritdoc />
    public partial class bla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department",
                column: "InsManager",
                principalTable: "Instructor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department",
                column: "InsManager",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
