using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMeter.Data.Migrations
{
    /// <inheritdoc />
    public partial class SonModelDuzenlemeleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Payment_PaymentId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_PaymentId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Payment",
                newName: "Recipe");

            migrationBuilder.AlterColumn<int>(
                name: "ParkSlotId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Payment",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "ParkSlots",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Payment",
                table: "Payment",
                column: "Payment");

            migrationBuilder.CreateIndex(
                name: "IX_ParkSlots_PaymentId",
                table: "ParkSlots",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSlots_Payment_PaymentId",
                table: "ParkSlots",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Vehicles_Payment",
                table: "Payment",
                column: "Payment",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSlots_Payment_PaymentId",
                table: "ParkSlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Vehicles_Payment",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_Payment",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_ParkSlots_PaymentId",
                table: "ParkSlots");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "ParkSlots");

            migrationBuilder.RenameColumn(
                name: "Recipe",
                table: "Payment",
                newName: "Amount");

            migrationBuilder.AlterColumn<int>(
                name: "ParkSlotId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_PaymentId",
                table: "Vehicles",
                column: "PaymentId",
                unique: true,
                filter: "[PaymentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Payment_PaymentId",
                table: "Vehicles",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id");
        }
    }
}
