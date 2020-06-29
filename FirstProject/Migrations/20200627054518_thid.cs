using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstProject.Migrations
{
    public partial class thid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "studentdetailsid",
                table: "student",
                //https://nodogmablog.bryanhogan.net/2015/04/entity-framework-non-null-foreign-key-migration/
                nullable: true, //to migrate perfectly with existing data you must put nullablle as true and create db and then 
                defaultValue: null);

            migrationBuilder.CreateIndex(
                name: "ix_student_studentdetailsid",
                table: "student",
                column: "studentdetailsid",
                unique: true);
    

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentDetails_StudentDetailsId",
                table: "Student",
                column: "StudentDetailsId",
                principalTable: "StudentDetails",
                principalColumn: "StudentDetailsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentDetails_StudentDetailsId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentDetailsId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentDetailsId",
                table: "Student");
        }
    }
}
