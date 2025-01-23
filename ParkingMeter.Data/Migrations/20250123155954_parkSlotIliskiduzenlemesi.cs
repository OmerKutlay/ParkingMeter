using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMeter.Data.Migrations
{
    /// <inheritdoc />
    public partial class parkSlotIliskiduzenlemesi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSlots_Vehicles_VehicleId",
                table: "ParkSlots");

            migrationBuilder.DropIndex(
                name: "IX_ParkSlots_VehicleId",
                table: "ParkSlots");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "ParkSlots");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ParkSlotId",
                table: "Vehicles",
                column: "ParkSlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_ParkSlots_ParkSlotId",
                table: "Vehicles",
                column: "ParkSlotId",
                principalTable: "ParkSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_ParkSlots_ParkSlotId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ParkSlotId",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "ParkSlots",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParkSlots_VehicleId",
                table: "ParkSlots",
                column: "VehicleId",
                unique: true,
                filter: "[VehicleId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSlots_Vehicles_VehicleId",
                table: "ParkSlots",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }
    }
}
