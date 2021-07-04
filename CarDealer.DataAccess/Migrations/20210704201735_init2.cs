using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealer.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Series_SeriesId",
                table: "Models");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Series_SeriesId",
                table: "Models",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Series_SeriesId",
                table: "Models");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Series_SeriesId",
                table: "Models",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
