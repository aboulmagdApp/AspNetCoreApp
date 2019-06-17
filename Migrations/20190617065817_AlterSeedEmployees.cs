using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreNewWeb.Migrations
{
    public partial class AlterSeedEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Mohamed aboulmagd");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name" },
                values: new object[,]
                {
                    { 2, 2, "Ahmed@Outlook.com", "Ahmed Hossam" },
                    { 3, 1, "shadi@gmail.com", "shadi hussan" },
                    { 4, 3, "Eman@gmail.com", "Eman Abdallah" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "aboulmagd");
        }
    }
}
