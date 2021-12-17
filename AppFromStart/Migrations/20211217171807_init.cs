using Microsoft.EntityFrameworkCore.Migrations;

namespace AppFromStart.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseNumber);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "CourseNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseNumber", "Description", "Name" },
                values: new object[] { 1, "Master teh art of databse", "RDBMS" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseNumber", "Description", "Name" },
                values: new object[] { 2, "Microsoft C# for Dotnet", "C#" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Course_Id", "Name", "Status" },
                values: new object[] { 101, 1, "Jim", "Registered" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Course_Id", "Name", "Status" },
                values: new object[] { 102, 1, "Jack", "Enrolled" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Course_Id",
                table: "Students",
                column: "Course_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
