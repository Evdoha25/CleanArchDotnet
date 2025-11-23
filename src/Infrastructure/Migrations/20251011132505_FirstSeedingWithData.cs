using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstSeedingWithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    {1 , "Alex"},
                    {2 , "Sergey"},
                    {3 , "Kate"},
                    {4 , "Simple"},
                    {5 , "Dods"}
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1
            );
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2
            );
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3
            );
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4
            );
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5
            );
        }
    }
}
