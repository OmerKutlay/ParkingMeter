using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMeter.Data.Migrations
{
    /// <inheritdoc />
    public partial class iliskiDuzenlemeleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSlots_Payments_PaymentId",
                table: "ParkSlots");

            migrationBuilder.DropIndex(
                name: "IX_ParkSlots_PaymentId",
                table: "ParkSlots");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "ParkSlots");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Parkings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Parkings");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "ParkSlots",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParkSlots_PaymentId",
                table: "ParkSlots",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSlots_Payments_PaymentId",
                table: "ParkSlots",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }
    }
}
