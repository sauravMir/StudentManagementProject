using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstProject.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Grade_GradeId1",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_GradeId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_GradeId1",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GradeId1",
                table: "Student");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_GradeId",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "GradeId1",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId1",
                table: "Student",
                column: "GradeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Grade_GradeId1",
                table: "Student",
                column: "GradeId1",
                principalTable: "Grade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
