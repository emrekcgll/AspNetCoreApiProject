using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_HotelID",
                table: "Comments",
                column: "HotelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Hotels_HotelID",
                table: "Comments",
                column: "HotelID",
                principalTable: "Hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Hotels_HotelID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_HotelID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "HotelID",
                table: "Comments");
        }
    }
}
