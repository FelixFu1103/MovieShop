using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class updatingPurchaseTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Purchase_UserId_MovieId",
                table: "Purchase");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Purchase",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 9.9m,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_UserId",
                table: "Purchase",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Purchase_UserId",
                table: "Purchase");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Purchase",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 9.9m);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_UserId_MovieId",
                table: "Purchase",
                columns: new[] { "UserId", "MovieId" },
                unique: true);
        }
    }
}
