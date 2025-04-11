using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject.Infraustraction.Migrations
{
    /// <inheritdoc />
    public partial class blah : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_departmetSubjects_Department_DID",
                table: "departmetSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_departmetSubjects_Subjects_SubID",
                table: "departmetSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Ins_Subject_Instructor_Ins_Id",
                table: "Ins_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Ins_Subject_Subjects_Sub_Id",
                table: "Ins_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Department_DID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudID",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_SubID",
                table: "StudentSubjects");

            migrationBuilder.AlterColumn<string>(
                name: "DName",
                table: "Department",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department",
                column: "InsManager",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_departmetSubjects_Department_DID",
                table: "departmetSubjects",
                column: "DID",
                principalTable: "Department",
                principalColumn: "DID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_departmetSubjects_Subjects_SubID",
                table: "departmetSubjects",
                column: "SubID",
                principalTable: "Subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ins_Subject_Instructor_Ins_Id",
                table: "Ins_Subject",
                column: "Ins_Id",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ins_Subject_Subjects_Sub_Id",
                table: "Ins_Subject",
                column: "Sub_Id",
                principalTable: "Subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Department_DID",
                table: "Students",
                column: "DID",
                principalTable: "Department",
                principalColumn: "DID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudID",
                table: "StudentSubjects",
                column: "StudID",
                principalTable: "Students",
                principalColumn: "StudID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_SubID",
                table: "StudentSubjects",
                column: "SubID",
                principalTable: "Subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_departmetSubjects_Department_DID",
                table: "departmetSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_departmetSubjects_Subjects_SubID",
                table: "departmetSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Ins_Subject_Instructor_Ins_Id",
                table: "Ins_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Ins_Subject_Subjects_Sub_Id",
                table: "Ins_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Department_DID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudID",
                table: "StudentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Subjects_SubID",
                table: "StudentSubjects");

            migrationBuilder.AlterColumn<string>(
                name: "DName",
                table: "Department",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InsManager",
                table: "Department",
                column: "InsManager",
                principalTable: "Instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_departmetSubjects_Department_DID",
                table: "departmetSubjects",
                column: "DID",
                principalTable: "Department",
                principalColumn: "DID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departmetSubjects_Subjects_SubID",
                table: "departmetSubjects",
                column: "SubID",
                principalTable: "Subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ins_Subject_Instructor_Ins_Id",
                table: "Ins_Subject",
                column: "Ins_Id",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ins_Subject_Subjects_Sub_Id",
                table: "Ins_Subject",
                column: "Sub_Id",
                principalTable: "Subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Department_DID",
                table: "Students",
                column: "DID",
                principalTable: "Department",
                principalColumn: "DID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudID",
                table: "StudentSubjects",
                column: "StudID",
                principalTable: "Students",
                principalColumn: "StudID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Subjects_SubID",
                table: "StudentSubjects",
                column: "SubID",
                principalTable: "Subjects",
                principalColumn: "SubID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
