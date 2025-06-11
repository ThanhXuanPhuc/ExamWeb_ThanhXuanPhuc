using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_ThanhXuanPhuc.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phims",
                columns: new[] { "Id", "DienVien", "GiaVe", "ThoiLuong", "TrongNuoc", "TuaDe" },
                values: new object[,]
                {
                    { 1, "Lý Hải", 75000.0, 110, true, "Lật Mặt 6" },
                    { 2, "Robert Downey Jr.", 95000.0, 181, false, "Avengers: Endgame" },
                    { 3, "Leonardo DiCaprio", 85000.0, 148, false, "Inception" },
                    { 4, "Trấn Thành", 80000.0, 128, true, "Bố Già" },
                    { 5, "Joaquin Phoenix", 90000.0, 122, false, "Joker" },
                    { 6, "Ngô Thanh Vân", 78000.0, 98, true, "Hai Phượng" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
